using milk_sales_manager.controls.extra_controls;
using milk_sales_manager.models;
using milk_sales_manager.modules;
using milk_sales_manager.Properties;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace milk_sales_manager.controls
{
    public partial class ThanhToanUC : UserControl
    {
        public ThanhToanUC(LoggedInUser user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        readonly LoggedInUser loggedInUser;
        private readonly Dictionary<string, string> dicPrice = new Dictionary<string, string>();

        private async void ThanhToanUC_Load(object sender, EventArgs e)
        {
            textBoxSanPham.Focus();
            textBoxTongTien.Text = "0";
            textBoxKhachHang.Text = "kh-khdonle";
            textBoxKhachHang.ForeColor = Color.Snow;
            labelChietKhau.Visible = false;
            labelChietKhauNumber.Visible = false;
            labelGiaGoc.Visible = false;
            labelGiaGocNumber.Visible = false;
            comboBoxPhuongThucThanhToan.SelectedIndex = 1;

            if (khachHang.maKhachHang == "kh-khdonle")
                checkBoxDungDiem.Visible = false;

            using (Entities vin = new Entities())
            {
                List<SanPham> sanPhams = await vin.SanPhams.AsNoTracking().ToListAsync();
                dataGridViewSanPham.DataSource = sanPhams;
                dataGridViewSanPham.Height = sanPhams.Count * 32 + 70;

                if (dataGridViewSanPham.Height > 424)
                    dataGridViewSanPham.Height = 424;

                List<KhachHang> khachHangs = await vin.KhachHangs.AsNoTracking().ToListAsync();
                dataGridViewKhachHang.DataSource = khachHangs;
                dataGridViewKhachHang.Height = khachHangs.Count * 32 + 70;

                if (dataGridViewKhachHang.Height > 326)
                    dataGridViewKhachHang.Height = 326;

                TimKiemKhachHang();
            }
        }

        private void DataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    string tenSanPham = dataGridViewSanPham["tenSanPhamDataGridViewTextBoxColumn", e.RowIndex].Value.ToString().Trim();

                    using (Entities vin = new Entities())
                    {
                        SanPham sanPham = vin.SanPhams.AsNoTracking().FirstOrDefault(s => s.tenSanPham == tenSanPham);
                        ChiTietSanPham chiTietSanPham = vin.ChiTietSanPhams.AsNoTracking().FirstOrDefault(c => c.maSanPham == sanPham.maSanPham);

                        if (!dicPrice.ContainsKey(sanPham.maSanPham))
                        {
                            string foNum = ReformatPrice(chiTietSanPham.giaBan) + " VND";
                            string[] sPs = new string[] { (dataGridViewHoaDon.Rows.Count + 1).ToString(), sanPham.maSanPham, sanPham.tenSanPham, "-", "1", "+", foNum, "xoa" };
                            dicPrice.Add(sanPham.maSanPham, foNum.Replace(" VND", ""));
                            dataGridViewHoaDon.Rows.Add(sPs);
                        }
                        else
                        {
                            DataGridViewRow fRow = null;

                            foreach (DataGridViewRow row in dataGridViewHoaDon.Rows)
                            {
                                if (row.Cells["maSanPhamDGVC"].Value != null && row.Cells["maSanPhamDGVC"].Value.ToString() == sanPham.maSanPham)
                                {
                                    fRow = row;
                                    break;
                                }
                            }

                            int soLuong = int.Parse(fRow.Cells["soLuongDGVC"].Value.ToString()) + 1;
                            int giaBan = (int)(chiTietSanPham.giaBan * soLuong);

                            foreach (DataGridViewRow row in dataGridViewHoaDon.Rows)
                            {
                                if (row.Cells["maSanPhamDGVC"].Value != null && row.Cells["maSanPhamDGVC"].Value.ToString() == sanPham.maSanPham)
                                {
                                    row.Cells["soLuongDGVC"].Value = soLuong;
                                    row.Cells["thanhTienDGVC"].Value = ReformatPrice(giaBan) + " VND";
                                }
                            }
                        }

                        string maSP = dataGridViewSanPham["maSanPhamDataGridViewTextBoxColumn", e.RowIndex].Value.ToString();

                        TinhTongTien(maSP);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    string maSP = dataGridViewHoaDon["maSanPhamDGVC", e.RowIndex].Value.ToString();

                    if (dataGridViewHoaDon.Columns[e.ColumnIndex].Name == "col_xoa")
                    {
                        string key = dataGridViewHoaDon["maSanPhamDGVC", e.RowIndex].Value.ToString();

                        dicPrice.Remove(key);
                        dataGridViewHoaDon.Rows.Remove(dataGridViewHoaDon.Rows[e.RowIndex]);
                    }
                    else if (dataGridViewHoaDon.Columns[e.ColumnIndex].Name == "soLuongDGVC")
                    {
                        dataGridViewHoaDon.BeginEdit(true);

                        if (dataGridViewHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewTextBoxCell)
                            dataGridViewHoaDon.EditingControl.Select();
                    }
                    else if (dataGridViewHoaDon.Columns[e.ColumnIndex].Name == "col_cong")
                    {
                        int sl = int.Parse(dataGridViewHoaDon["soLuongDGVC", e.RowIndex].Value.ToString());

                        sl++;

                        dataGridViewHoaDon["soLuongDGVC", e.RowIndex].Value = sl;
                    }
                    else if (dataGridViewHoaDon.Columns[e.ColumnIndex].Name == "col_tru")
                    {
                        int sl = int.Parse(dataGridViewHoaDon["soLuongDGVC", e.RowIndex].Value.ToString());

                        if (sl > 1)
                            sl--;

                        dataGridViewHoaDon["soLuongDGVC", e.RowIndex].Value = sl;
                    }

                    TinhTongTien(maSP);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hoa_don cellClick error: " + ex.Message);
            }
        }

        private string ReformatPrice(double price)
        {
            try
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                return price.ToString("N0", cul);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi chuyen dinh dang so: " + ex.Message);
                return price.ToString("N0");
            }
        }

        private void TinhTongTien(string maSP)
        {
            try
            {
                DataGridViewRow dataRow = dataGridViewHoaDon.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells["maSanPhamDGVC"].Value.ToString() == maSP);

                if (dataRow != null)
                {
                    int rowIndex = dataRow.Index;

                    string maSanPhamSP = dataGridViewSanPham["maSanPhamDataGridViewTextBoxColumn", rowIndex].Value.ToString();
                    string maSanPhamHD = dataGridViewHoaDon["maSanPhamDGVC", rowIndex].Value.ToString();

                    long pri = int.Parse(dicPrice[maSP].Replace(".", ""));
                    string sl = dataGridViewHoaDon["soLuongDGVC", rowIndex].Value.ToString();
                    long price = pri;

                    if (int.TryParse(sl, out int intSL))
                    {
                        if (intSL <= 0)
                        {
                            intSL = 1;
                            dataGridViewHoaDon["soLuongDGVC", rowIndex].Value = intSL;
                        }

                        price = pri * intSL;
                    }
                    else
                    {
                        dataGridViewHoaDon["soLuongDGVC", rowIndex].Value = 1;
                    }

                    dataGridViewHoaDon["thanhTienDGVC", rowIndex].Value = ReformatPrice(price) + " VND";
                }

                long tongTien = 0;

                foreach (DataGridViewRow row in dataGridViewHoaDon.Rows)
                {
                    tongTien += long.Parse(row.Cells["thanhTienDGVC"].Value.ToString().Replace(".", "").Replace(" VND", ""));
                }

                labelGiaGocNumber.Text = ReformatPrice(tongTien);
                textBoxTongTien.Text = ReformatPrice(tongTien);

                if (checkBoxDungDiem.Checked)
                    TinhChietKhau(khachHang.diemTichLuy);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi tinh tong tien: " + ex.Message);
            }
        }

        private void TextBoxSanPham_TextChanged(object sender, EventArgs e)
        {
            RegexInput reg = new RegexInput();

            using (Entities vin = new Entities())
            {
                string keyword = reg.RemoveVietnameseMarks(textBoxSanPham.Text.ToLower());
                List<SanPham> sanPhams = vin.SanPhams.AsNoTracking().ToList();
                List<SanPham> filteredSanPhams = sanPhams.Where(s => reg.RemoveVietnameseMarks(s.tenSanPham.ToLower()).Contains(keyword) || s.maSanPham.Contains(keyword)).ToList();
                dataGridViewSanPham.DataSource = filteredSanPhams;
                dataGridViewSanPham.Height = filteredSanPhams.Count * 32 + 70;

                if (dataGridViewSanPham.Height > 424)
                    dataGridViewSanPham.Height = 424;
            }
        }

        private void DataGridViewHoaDon_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewHoaDon.Columns["col_xoa"].Index && e.Value != null)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                Color buttonColor = Color.OrangeRed;

                using (Brush brush = new SolidBrush(buttonColor))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds.X + 2, e.CellBounds.Y + 2, e.CellBounds.Width - 4, e.CellBounds.Height - 4);
                    SizeF textSize = e.Graphics.MeasureString("Xóa", e.CellStyle.Font);
                    float x = e.CellBounds.X + (e.CellBounds.Width - textSize.Width) / 2;
                    float y = e.CellBounds.Y + (e.CellBounds.Height - textSize.Height) / 2;
                    e.Graphics.DrawString("Xóa", e.CellStyle.Font, Brushes.White, x, y);
                }

                e.Handled = true;
            }
        }

        private void DataGridViewHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string maSP = dataGridViewHoaDon["maSanPhamDGVC", e.RowIndex].Value.ToString();

                TinhTongTien(maSP);

                ButtonClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi thay đoi so luong: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxKhachHang_TextChanged(object sender, EventArgs e)
        {
            TimKiemKhachHang();
        }

        private void TimKiemKhachHang()
        {
            try
            {
                RegexInput reg = new RegexInput();

                using (Entities vinamilkEntities = new Entities())
                {
                    string keyword = reg.RemoveVietnameseMarks(textBoxKhachHang.Text.ToLower());

                    List<KhachHang> khachHangs = vinamilkEntities.KhachHangs.ToList();
                    List<KhachHang> filteredKhachHangs = khachHangs.Where(s => reg.RemoveVietnameseMarks(s.tenKhachHang.ToLower()).Contains(keyword) || s.maKhachHang.Contains(keyword)).ToList();

                    dataGridViewKhachHang.DataSource = filteredKhachHangs;
                    dataGridViewKhachHang.Height = filteredKhachHangs.Count * 32 + 70;

                    if (dataGridViewKhachHang.Height > 326)
                        dataGridViewKhachHang.Height = 326;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxKhachHang_Enter(object sender, EventArgs e)
        {
            if (textBoxKhachHang.Text == "kh-khdonle")
            {
                textBoxKhachHang.Clear();
                textBoxKhachHang.ForeColor = Color.Black;
            }
        }

        private void TextBoxKhachHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxKhachHang.Text))
            {
                textBoxKhachHang.Text = "kh-khdonle";
                textBoxKhachHang.ForeColor = Color.Snow;
            }
        }

        KhachHang khachHang = new KhachHang
        {
            maKhachHang = "kh-khdonle"
        };

        private void DataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string maKhach = dataGridViewKhachHang["maKhachHangDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty;

                if (!string.IsNullOrEmpty(maKhach))
                {
                    using (Entities vinamilkEntities = new Entities())
                    {
                        khachHang = vinamilkEntities.KhachHangs.AsNoTracking().FirstOrDefault(k => k.maKhachHang == maKhach);
                    }

                    textBoxKhachHang.Text = maKhach;
                    textBoxKhachHang.ForeColor = Color.Snow;

                    if (khachHang.maKhachHang == "kh-khdonle")
                        checkBoxDungDiem.Visible = false;
                    else
                        checkBoxDungDiem.Visible = true;
                }
            }
        }

        private void TinhChietKhau(int diemTich)
        {
            double oldTong = double.Parse(textBoxTongTien.Text.Replace(".", ""));
            bool isDiscountApplicable = diemTich > 0 && oldTong / 1000 > 2990;

            if (isDiscountApplicable)
            {
                double chietkhau = diemTich * 10000;
                double phanTram = oldTong * 0.1;

                double newTong = oldTong - Math.Min(chietkhau, phanTram);

                labelChietKhauNumber.Text = ReformatPrice(Math.Min(chietkhau, phanTram));
                textBoxTongTien.Text = ReformatPrice(newTong);
            }

            labelChietKhau.Visible = isDiscountApplicable;
            labelChietKhauNumber.Visible = isDiscountApplicable;
            labelGiaGoc.Visible = isDiscountApplicable;
            labelGiaGocNumber.Visible = isDiscountApplicable;
        }

        private void CheckBoxDungDiem_CheckedChanged(object sender, EventArgs e)
        {
            int oldTong = int.Parse(labelGiaGocNumber.Text.Replace(".", ""));

            if (khachHang.diemTichLuy > 10 && oldTong / 1000 > 2990)
            {
                if (checkBoxDungDiem.Checked)
                {
                    TinhChietKhau(khachHang.diemTichLuy);
                }
                else
                {
                    textBoxTongTien.Text = ReformatPrice(double.Parse(labelGiaGocNumber.Text.Replace(".", "")));

                    labelChietKhau.Visible = false;
                    labelChietKhauNumber.Visible = false;
                    labelGiaGoc.Visible = false;
                    labelGiaGocNumber.Visible = false;
                }
            }
            else
            {
                if (checkBoxDungDiem.Checked)
                {
                    checkBoxDungDiem.Checked = false;
                    MessageBox.Show("Khách hàng chưa đủ điều kiện để sử dụng điểm tích lũy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxKhachHang.Text = "kh-khdonle";
            textBoxKhachHang.ForeColor = Color.Snow;
            checkBoxDungDiem.Checked = false;
            checkBoxDungDiem.Visible = false;
        }

        readonly List<ChiTietDonHang> chiTietDonHangs = new List<ChiTietDonHang>();

        private void ButtonThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewHoaDon.Rows.Count > 0)
                {
                    string maChiTiet = GenerateMa("ct");

                    DonHang donHang = new DonHang
                    {
                        maDonHang = "dh" + DateTime.Now.ToString("yyyyMMddHHmmssffff"),
                        maKhachHang = khachHang.maKhachHang,
                        maNhanVien = loggedInUser.Username,
                        hinhThucThanhToan = comboBoxPhuongThucThanhToan.SelectedItem.ToString(),
                        ngayTao = DateTime.Now,
                        giaGiam = double.Parse(labelChietKhauNumber.Text.Replace(".", "")),
                        tongTien = double.Parse(textBoxTongTien.Text.Replace(".", "")),
                        trangThai = true
                    };

                    if (donHang.hinhThucThanhToan.Contains("--"))
                        throw new Exception("Vui lòng chọn phương thức thanh toán!");

                    using (Entities vinamilkEntities = new Entities())
                    {
                        foreach (DataGridViewRow row in dataGridViewHoaDon.Rows)
                        {
                            string msp = row.Cells["maSanPhamDGVC"].Value.ToString();
                            short sl = short.Parse(row.Cells["soLuongDGVC"].Value.ToString());
                            double tt = double.Parse(row.Cells["thanhTienDGVC"].Value.ToString().Replace(".", "").Replace(" VND", ""));
                            double gia = vinamilkEntities.ChiTietSanPhams.AsNoTracking().FirstOrDefault(s => s.maSanPham == msp).giaBan;

                            ChiTietDonHang chiTietDonHang = new ChiTietDonHang
                            {
                                maChiTietDonHang = maChiTiet,
                                maDonHang = donHang.maDonHang,
                                maSanPham = msp,
                                soLuong = sl,
                                thanhTien = tt,
                                donGia = gia
                            };

                            chiTietDonHangs.Add(chiTietDonHang);
                        }

                        vinamilkEntities.DonHangs.Add(donHang);

                        foreach (ChiTietDonHang chiTiet in chiTietDonHangs)
                        {
                            vinamilkEntities.ChiTietDonHangs.Add(chiTiet);

                            ChiTietSanPham chi = vinamilkEntities.ChiTietSanPhams.FirstOrDefault(s => s.maSanPham == chiTiet.maSanPham);

                            if (chi != null)
                                chi.soLuong -= chiTiet.soLuong;
                        }

                        if (donHang.maKhachHang != "kh-khdonle")
                        {
                            KhachHang khachHang = vinamilkEntities.KhachHangs.FirstOrDefault(k => k.maKhachHang == donHang.maKhachHang);

                            double chietKhau = double.Parse(labelChietKhauNumber.Text.Replace(".", ""));
                            double diemTichLuy = (khachHang.diemTichLuy - (chietKhau / 100000)) + (donHang.tongTien / 100000);

                            khachHang.diemTichLuy = (int)diemTichLuy;
                        }

                        vinamilkEntities.SaveChanges();
                    }

                    if (MessageBox.Show("Bạn có muốn in hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        maDonHang = donHang.maDonHang;

                        PrintBill();
                    }

                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dicPrice.Clear();
                    dataGridViewHoaDon.Rows.Clear();
                    textBoxKhachHang.Text = "kh-khdonle";
                    textBoxKhachHang.ForeColor = Color.Snow;
                    textBoxTongTien.Text = "0";
                    labelChietKhauNumber.Text = "0";
                    labelGiaGocNumber.Text = "0";
                    checkBoxDungDiem.Checked = false;
                    checkBoxDungDiem.Visible = false;
                    labelChietKhau.Visible = false;
                    labelChietKhauNumber.Visible = false;
                    textBoxSanPham.Clear();
                    chiTietDonHangs.Clear();

                    TimKiemKhachHang();
                }
                else
                {
                    throw new Exception("Không có sản phẩm nào để thanh toán!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateMa(string key)
        {
            if (key.Length > 2)
                key = key.Substring(0, 2);

            Random random = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            string randomString = new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
            string randomDigits = new string(Enumerable.Repeat(digits, 2).Select(s => s[random.Next(s.Length)]).ToArray());
            string finalString = key + randomString + randomDigits;

            return finalString;
        }

        private void PrintBill()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            PrintDialog printDialog = new PrintDialog { Document = printDocument };

            printDocument.Print();
        }

        private string maDonHang;

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Arial", 12, FontStyle.Regular);
            NhanVien nhanVien = new NhanVien();
            DataGridViewRow dataRow = dataGridViewKhachHang.CurrentRow;
            string maKhachHang = dataRow.Cells["maKhachHangDataGridViewTextBoxColumn"].Value.ToString();
            KhachHang khachHang = new KhachHang();

            using (Entities vinamilkEntities = new Entities())
            {
                nhanVien = vinamilkEntities.NhanViens.AsNoTracking().FirstOrDefault(n => n.maNhanVien == loggedInUser.Username);
                khachHang = vinamilkEntities.KhachHangs.AsNoTracking().FirstOrDefault(k => k.maKhachHang == maKhachHang);

                int xl1 = 60, yl1 = 438, xl2 = 790, yl2 = 438;
                int xs1 = 60, ys1 = 468;
                int s = 1;

                foreach (ChiTietDonHang chi in chiTietDonHangs)
                {
                    SanPham sanPham = vinamilkEntities.SanPhams.AsNoTracking().FirstOrDefault(sa => sa.maSanPham == chi.maSanPham);
                    ChiTietSanPham chiTietSanPham = vinamilkEntities.ChiTietSanPhams.AsNoTracking().FirstOrDefault(sa => sa.maSanPham == sanPham.maSanPham);
                    DonVi donVi = vinamilkEntities.DonVis.AsNoTracking().FirstOrDefault(d => d.maDonVi == chiTietSanPham.maDonVi);

                    List<string> tenSPs = CatDongTenSanPham(sanPham.tenSanPham);
                    string tenSP = string.Empty;

                    foreach (string te in tenSPs)
                    {
                        tenSP += te + "\n";
                    }

                    graphic.DrawString(s.ToString(), font, Brushes.Black, xs1 + 10, ys1 - 24);
                    graphic.DrawString(tenSP, font, Brushes.Black, xs1 + 40, ys1 - 24);
                    graphic.DrawString(donVi.tenDonVi, font, Brushes.Black, xs1 + 388, ys1 - 24);
                    graphic.DrawString(chi.soLuong.ToString(), font, Brushes.Black, xs1 + 470, ys1 - 24);
                    graphic.DrawString(chiTietSanPham.giaBan.ToString(), font, Brushes.Black, xs1 + 525, ys1 - 24);
                    graphic.DrawString(chi.thanhTien.ToString(), font, Brushes.Black, xs1 + 625, ys1 - 24);

                    yl1 += 24 * tenSPs.Count;
                    yl2 += 24 * tenSPs.Count;
                    ys1 += 24 * tenSPs.Count;

                    graphic.DrawLine(new Pen(Brushes.Black, 1), xl1, yl1, xl2, yl2);

                    s++;
                }
            }

            graphic.DrawImage(Resources.vinamilk_logo_new, 56, 64, 128, 72);
            graphic.DrawString("CÔNG TY CỔ  PHẦN SỮA VINAMILK", new Font("Arial", 24, FontStyle.Bold), Brushes.Black, 192, 56);
            graphic.DrawString("Địa chỉ: Số 10, Đường Tân Trào, phường Tân Phú, quận 7, Tp. HCM\n" +
                "Điện thoại: (028) 54 155 555 | (028) 54 161 226\n" +
                "Hòm thư điện tử: vinamilk@vinamilk.com.vn", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 210, 96);

            graphic.DrawLine(new Pen(Color.Black, 1), 60, 168, 790, 168);
            graphic.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 292, 180);
            graphic.DrawString("Mã đơn hàng: \t\t" + maDonHang +
                "\nNgày bán: \t\t" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") +
                "\nNhân viên bán hàng: \t" + nhanVien.tenNhanVien, font, Brushes.Black, 64, 220);

            graphic.DrawLine(new Pen(Color.Black, 1), 60, 290, 790, 290);
            graphic.DrawString("Người mua hàng: \t" + khachHang.tenKhachHang +
                "\nĐịa chỉ: \t\t\t" + khachHang.diaChi +
                "\nSố điện thoại: \t\t" + khachHang.soDienThoai +
                "\nThư điện tử: \t\t" + khachHang.email +
                "\nHình thức thanh toán: \t" + comboBoxPhuongThucThanhToan.SelectedItem.ToString(), font, Brushes.Black, 64, 300);

            graphic.DrawRectangle(new Pen(Color.Black, 1), 60, 408, 730, 512);
            graphic.DrawString("Tổng tiền hàng: \t " + labelGiaGocNumber.Text.ToString() + " VND", font, Brushes.Black, 500, 940);
            graphic.DrawString("Giảm: \t\t " + labelChietKhauNumber.Text.ToString() + " VND", font, Brushes.Red, 500, 960);
            graphic.DrawString("Tổng thanh toán: " + textBoxTongTien.Text.ToString() + " VND", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 500, 990);

            graphic.DrawString("CHỮ KÝ NGƯỜI BÁN\n  (Ký, ghi rõ họ tên)", font, Brushes.Black, 70, 940);
            graphic.DrawString("CHỮ KÝ NGƯỜI MUA\n  (Ký, ghi rõ họ tên)", font, Brushes.Black, 280, 940);

            graphic.DrawLine(new Pen(Color.Black, 1), 60, 438, 790, 438);
            graphic.DrawString("STT\t\tTên sản phẩm\t\t           Đơn vị         SL           Giá           Thành tiền", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 62, 416);
            graphic.DrawLine(new Pen(Color.Black, 1), 100, 408, 100, 920);
            graphic.DrawLine(new Pen(Color.Black, 1), 440, 408, 440, 920);
            graphic.DrawLine(new Pen(Color.Black, 1), 520, 408, 520, 920);
            graphic.DrawLine(new Pen(Color.Black, 1), 580, 408, 580, 920);
            graphic.DrawLine(new Pen(Color.Black, 1), 680, 408, 680, 920);

            chiTietDonHangs.Clear();
        }

        private List<string> CatDongTenSanPham(string ten)
        {
            int chunkLength = 38;
            List<string> result = new List<string>();

            for (int i = 0; i < ten.Length; i += chunkLength)
            {
                if (i + chunkLength > ten.Length)
                {
                    result.Add(ten.Substring(i));
                }
                else
                {
                    result.Add(ten.Substring(i, chunkLength));
                }
            }

            return result;
        }

        private void ButtonLichSuHoaDon_Click(object sender, EventArgs e)
        {
            LichSuHoaDonUC lic = new LichSuHoaDonUC(loggedInUser);
            lic.BackButtonClicked += Uc_back;

            Controls.Clear();
            Controls.Add(lic);
            lic.BackColor = Color.MintCream;
            lic.Dock = DockStyle.Fill;
            lic.BringToFront();
        }

        private void Uc_back(object sender, EventArgs e)
        {
            Controls.Remove(sender as Control);

            Controls.Add(panelChiTiet);
            Controls.Add(panelLeft);
        }
    }
}
