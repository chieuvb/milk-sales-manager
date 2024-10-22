using milk_sales_manager.controls.extra_controls;
using milk_sales_manager.models;
using milk_sales_manager.modules;
using milk_sales_manager.Properties;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace milk_sales_manager.controls
{
    public partial class SanPhamUC : UserControl
    {
        public SanPhamUC(LoggedInUser user)
        {
            InitializeComponent();
            imageProcess = new ImageProcess(true, cacheImage);
            loggedInUser = user;
        }

        readonly ImageProcess imageProcess;
        readonly Dictionary<string, Image> cacheImage = new Dictionary<string, Image>();
        SanPham sanPham = new SanPham();
        readonly LoggedInUser loggedInUser;

        private void SanPhamUC_LoadAsync(object sender, EventArgs e)
        {
            try
            {
                gro_boloc.Visible = false;
                panelChiTiet.Visible = false;

                if (!loggedInUser.Role.Contains("admin"))
                {
                    panelMenu.Visible = false;
                    buttonSave.Visible = false;
                    buttonDelete.Visible = false;
                }

                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi động: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void RefreshData()
        {
            try
            {
                using (Entities vin = new Entities())
                {
                    dat_sanpham.DataSource = await vin.SanPhams.AsNoTracking().ToListAsync();

                    com_nhasanxuat.Items.Clear();
                    com_nhasanxuat.Items.Add("-- Nhà sản xuất --");
                    string[] nhaSX = await vin.NhaSanXuats.Select(nsx => nsx.tenNhaSanXuat).ToArrayAsync();
                    foreach (string s in nhaSX)
                    {
                        if (!com_nhasanxuat.Items.Contains(s))
                            com_nhasanxuat.Items.Add(s);
                    }
                    com_nhasanxuat.SelectedIndex = 0;

                    com_doituong.Items.Clear();
                    com_doituong.Items.Add("-- Đối tượng sử dụng --");
                    string[] doiT = await vin.DoiTuongs.Select(dt => dt.tenDoiTuong).ToArrayAsync();
                    foreach (string d in doiT)
                    {
                        if (!com_doituong.Items.Contains(d))
                            com_doituong.Items.Add(d);
                    }
                    com_doituong.SelectedIndex = 0;

                    comboBoxDonVi.Items.Clear();
                    comboBoxDonVi.Items.Add("-- Đơn vị tính --");
                    string[] donV = await vin.DonVis.Select(dv => dv.tenDonVi).ToArrayAsync();
                    foreach (string d in donV)
                    {
                        if (!comboBoxDonVi.Items.Contains(d))
                            comboBoxDonVi.Items.Add(d);
                    }
                    comboBoxDonVi.SelectedIndex = 0;
                }

                panelChiTiet.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Dat_sanpham_CellClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    panelChiTiet.Visible = true;

                    string maSanPham = dat_sanpham["maSanPhamC", e.RowIndex].Value?.ToString() ?? string.Empty;
                    string imageKey = null;

                    using (Entities vin = new Entities())
                    {
                        sanPham = await vin.SanPhams.FirstOrDefaultAsync(s => s.maSanPham == maSanPham);

                        ChiTietSanPham chiTiet = await vin.ChiTietSanPhams.FirstOrDefaultAsync(c => c.maSanPham == maSanPham);
                        NhaSanXuat nha = await vin.NhaSanXuats.FirstOrDefaultAsync(n => n.maNhaSanXuat == sanPham.maNhaSanXuat);
                        DoiTuong doi = await vin.DoiTuongs.FirstOrDefaultAsync(d => d.maDoiTuong == sanPham.maDoiTuong);
                        DonVi don = await vin.DonVis.FirstOrDefaultAsync(d => d.maDonVi == chiTiet.maDonVi);

                        if (sanPham != null && chiTiet != null)
                        {
                            tex_masanpham.Text = sanPham.maSanPham;
                            tex_tensanpham.Text = sanPham.tenSanPham;
                            tex_mota.Text = sanPham.moTa;
                            com_nhasanxuat.SelectedItem = nha?.tenNhaSanXuat;
                            com_doituong.SelectedItem = doi?.tenDoiTuong;
                            che_trangthai.Checked = sanPham.trangThai;

                            dat_nsx.Value = chiTiet.ngaySanXuat;
                            dat_hsd.Value = chiTiet.ngayHetHan;
                            tex_soluong.Text = chiTiet.soLuong.ToString();
                            comboBoxDonVi.SelectedItem = don?.tenDonVi;
                            textBoxGiaNhap.Text = chiTiet.giaNhap.ToString();

                            imageKey = chiTiet.hinhAnh.Trim();
                        }
                    }

                    if (imageKey != null)
                        imageProcess.LoadAndCacheImage(imageKey, cacheImage);

                    if (cacheImage.ContainsKey(imageKey))
                        pictureBoxSanPham.Image = cacheImage[imageKey];
                    else
                        pictureBoxSanPham.Image = cacheImage["no-image"];

                    if (pictureBoxSanPham.Image != null)
                    {
                        if (pictureBoxSanPham.Image.Width <= 128 && pictureBoxSanPham.Image.Height <= 128)
                            pictureBoxSanPham.SizeMode = PictureBoxSizeMode.CenterImage;
                        else
                            pictureBoxSanPham.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                        pictureBoxSanPham.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chuyển dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void But_them_Click(object sender, EventArgs e)
        {
            panelChiTiet.Visible = true;

            foreach (Control con in panelChiTiet.Controls)
            {
                switch (con)
                {
                    case TextBox textBox:
                        textBox.Clear();
                        break;
                    case ComboBox comboBox:
                        comboBox.SelectedIndex = 0;
                        break;
                    case DateTimePicker dateTimePicker:
                        dateTimePicker.Value = DateTime.Now;
                        break;
                }
            }

            pictureBoxSanPham.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxSanPham.Image = Resources.icons8_add_image_96;
            tex_tensanpham.Focus();
        }

        private void But_luu_Click(object sender, EventArgs e)
        {
            try
            {
                string result = ValidateInputs();

                if (result == "success")
                {
                    using (Entities vin = new Entities())
                    {
                        SanPham existingSanPham = vin.SanPhams.FirstOrDefault(s => s.maSanPham == sanPham.maSanPham);
                        if (existingSanPham == null)
                            AddNewSanPham(vin);
                        else
                            UpdateSanPham(vin, existingSanPham);
                    }
                }
                else
                    throw new Exception(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidateInputs()
        {
            try
            {
                if (string.IsNullOrEmpty(tex_tensanpham.Text))
                    return "Bạn chưa nhập tên sản phẩm!";
                else if (string.IsNullOrEmpty(tex_mota.Text))
                    return "Bạn cần mô tả cho sản phẩm!";
                else if (com_nhasanxuat.SelectedIndex == 0)
                    return "Bạn cần chọn nhà sản xuất!";
                else if (com_doituong.SelectedIndex == 0)
                    return "Bạn cần chọn đối tượng sử dụng!";
                else if (dat_nsx.Value >= DateTime.Now)
                    return "Ngày sản xuất không hợp lệ!";
                else if (dat_hsd.Value <= dat_nsx.Value)
                    return "Hạn sử dụng không hợp lệ!";
                else if (string.IsNullOrEmpty(tex_soluong.Text))
                    return "Số lượng không hợp lệ!";
                else if (comboBoxDonVi.SelectedIndex == 0)
                    return "Đơn vị tính không hợp lệ!";
                else if (string.IsNullOrEmpty(textBoxGiaNhap.Text))
                    return "Giá nhập không hợp lệ!";
                else
                    return "success";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "fail";
            }
        }

        private void AddNewSanPham(Entities vin)
        {
            try
            {
                GenerateString gen = new GenerateString();

                string maSanPham = gen.StringID("sp", tex_tensanpham.Text);

                SanPham sanPh = CreateSanPhamObject(maSanPham, vin);
                ChiTietSanPham chiTietSanPham = CreateChiTietSanPhamObject(maSanPham);

                vin.SanPhams.Add(sanPh);
                vin.SaveChanges();
                chiTietSanPham.maSanPham = maSanPham;
                vin.ChiTietSanPhams.Add(chiTietSanPham);

                vin.SaveChanges();

                RefreshData();

                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sản phẩm mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private SanPham CreateSanPhamObject(string msp, Entities vin)
        {
            try
            {
                string tenSanPham = tex_tensanpham.Text ?? string.Empty;
                string moTa = tex_mota.Text ?? string.Empty;
                bool trangThai = che_trangthai.Checked;
                string selectedDoiTuong = com_doituong.SelectedItem?.ToString() ?? string.Empty;
                string maDT = vin.DoiTuongs.FirstOrDefault(d => d.tenDoiTuong == selectedDoiTuong)?.maDoiTuong ?? "";
                string selectedNhaSanXuat = com_nhasanxuat.SelectedItem?.ToString() ?? string.Empty;
                string maNX = vin.NhaSanXuats.FirstOrDefault(n => n.tenNhaSanXuat == selectedNhaSanXuat)?.maNhaSanXuat ?? "";

                SanPham sanPham = new SanPham
                {
                    maSanPham = msp,
                    tenSanPham = tenSanPham,
                    moTa = moTa,
                    maDoiTuong = maDT,
                    maNhaSanXuat = maNX,
                    trangThai = trangThai
                };

                return sanPham;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private ChiTietSanPham CreateChiTietSanPhamObject(string msp)
        {
            try
            {
                int giaNhap = int.Parse(textBoxGiaNhap.Text ?? "0");
                int giaBan = int.Parse(textBoxGiaBan.Text ?? "0");

                string hinhAnh = imageProcess.SaveAndCacheImage(msp, pictureBoxSanPham.Image, cacheImage);

                using (Entities vin = new Entities())
                {
                    string maDonVi = vin.DonVis.FirstOrDefault(d => d.tenDonVi == comboBoxDonVi.SelectedItem.ToString())?.maDonVi;
                    ChiTietSanPham chiTietSanPham = new ChiTietSanPham
                    {
                        maChiTietSanPham = "ctsp" + DateTime.Now.ToString("ssffff"),
                        maSanPham = msp,
                        maDonVi = maDonVi,
                        hinhAnh = hinhAnh,
                        ngaySanXuat = dat_nsx.Value,
                        ngayHetHan = dat_hsd.Value,
                        giaNhap = giaNhap,
                        giaBan = giaBan,
                        soLuong = int.Parse(tex_soluong.Text ?? "0")
                    };

                    return chiTietSanPham;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo chi tiết sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void UpdateSanPham(Entities vin, SanPham sanPham)
        {
            try
            {
                NhaSanXuat nhaSanXuat = vin.NhaSanXuats.FirstOrDefault(n => n.tenNhaSanXuat == com_nhasanxuat.SelectedItem.ToString());
                DoiTuong doiTuong = vin.DoiTuongs.FirstOrDefault(d => d.tenDoiTuong == com_doituong.SelectedItem.ToString());
                ChiTietSanPham chiTietSanPham = vin.ChiTietSanPhams.FirstOrDefault(c => c.maSanPham == sanPham.maSanPham);
                DonVi donVi = vin.DonVis.FirstOrDefault(d => d.tenDonVi == comboBoxDonVi.SelectedItem.ToString());

                string newAnh = sanPham.maSanPham;

                imageProcess.UpdateImage(newAnh, pictureBoxSanPham.Image, cacheImage);

                sanPham.maNhaSanXuat = nhaSanXuat.maNhaSanXuat;
                sanPham.maDoiTuong = doiTuong.maDoiTuong;
                sanPham.tenSanPham = tex_tensanpham.Text;
                sanPham.moTa = tex_mota.Text;
                sanPham.trangThai = che_trangthai.Checked;

                chiTietSanPham.maDonVi = donVi.maDonVi;
                chiTietSanPham.hinhAnh = newAnh;
                chiTietSanPham.ngaySanXuat = dat_nsx.Value;
                chiTietSanPham.ngayHetHan = dat_hsd.Value;
                chiTietSanPham.giaNhap = double.Parse(textBoxGiaNhap.Text);
                chiTietSanPham.giaBan = double.Parse(textBoxGiaBan.Text);
                chiTietSanPham.soLuong = int.Parse(tex_soluong.Text);

                vin.SaveChanges();

                RefreshData();

                MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void But_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có thực sự muốn xóa sản phẩm: \"" + tex_tensanpham.Text + "\"?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    using (Entities vin = new Entities())
                    {
                        SanPham sanPham = vin.SanPhams.FirstOrDefault(s => s.maSanPham == tex_masanpham.Text);
                        ChiTietSanPham chiTiet = vin.ChiTietSanPhams.FirstOrDefault(c => c.maSanPham == tex_masanpham.Text);
                        if (sanPham != null && chiTiet != null)
                        {
                            imageProcess.DeleteImage(chiTiet.maSanPham, cacheImage);

                            vin.ChiTietSanPhams.Remove(chiTiet);
                            vin.SanPhams.Remove(sanPham);
                            vin.SaveChanges();

                            RefreshData();

                            panelChiTiet.Visible = false;
                            MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void But_timkiem_Click(object sender, EventArgs e)
        {
            TimKiemSanPham();
        }

        private void Tex_timkiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemSanPham();
        }

        private void TimKiemSanPham()
        {
            try
            {
                if (tex_timkiem.Text == "Nhập mã sản phẩm hoặc tên sản phẩm ở đây!")
                    return;

                RegexInput reg = new RegexInput();

                using (Entities vin = new Entities())
                {
                    string keyword = reg.RemoveVietnameseMarks(tex_timkiem.Text.ToLower());

                    List<SanPham> sanPhams = vin.SanPhams.ToList();

                    List<SanPham> filteredSanPhams = sanPhams.Where(s => reg.RemoveVietnameseMarks(s.tenSanPham.ToLower()).Contains(keyword) || s.maSanPham.Contains(keyword)).ToList();

                    dat_sanpham.DataSource = filteredSanPhams;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void But_loc_Click(object sender, EventArgs e)
        {
            if (gro_boloc.Visible)
            {
                gro_boloc.Visible = false;
                pan_timkiem.Height = 52;
            }
            else
            {
                gro_boloc.Visible = true;
                pan_timkiem.Height = 256;
            }
        }

        private void Tex_timkiem_Enter(object sender, EventArgs e)
        {
            if (tex_timkiem.Text == "Nhập mã sản phẩm hoặc tên sản phẩm ở đây!")
            {
                tex_timkiem.Clear();
            }
            tex_timkiem.ForeColor = Color.Black;
            tex_timkiem.Font = new Font("Arial", 12);
        }

        private void Tex_timkiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tex_timkiem.Text))
            {
                tex_timkiem.Text = "Nhập mã sản phẩm hoặc tên sản phẩm ở đây!";
                tex_timkiem.ForeColor = Color.Gray;
                tex_timkiem.Font = new Font("Arial", 12, FontStyle.Italic);
            }
        }

        private void Pic_sanpham_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    pictureBoxSanPham.SizeMode = PictureBoxSizeMode.Zoom;
                    Image image = Image.FromFile(imagePath);
                    pictureBoxSanPham.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tsm_nsx_Click(object sender, EventArgs e)
        {
            NhaSanXuatUC nha = new NhaSanXuatUC();
            nha.BackButtonClicked += Uc_back;

            OpenUserControl(nha);
        }

        private void Uc_back(object sender, EventArgs e)
        {
            pan_grid.Controls.Remove(sender as Control);

            pan_grid.Controls.Add(dat_sanpham);
            pan_grid.Controls.Add(pan_timkiem);
            pan_timkiem.Visible = true;
            panelChiTiet.Visible = true;
        }

        private void OpenUserControl(UserControl uc)
        {
            pan_timkiem.Visible = false;
            panelChiTiet.Visible = false;

            pan_grid.Controls.Clear();
            pan_grid.Controls.Add(uc);
            uc.BackColor = Color.MintCream;
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }

        private void Tsm_phanloai_Click(object sender, EventArgs e)
        {
            DoiTuongUC doi = new DoiTuongUC();
            doi.BackButtonClicked += Uc_back;

            OpenUserControl(doi);
        }

        private void Tsm_donvi_Click(object sender, EventArgs e)
        {
            DonViTinhUC don = new DonViTinhUC();
            don.BackButtonClicked += Uc_back;

            OpenUserControl(don);
        }

        private void Dat_sanpham_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dat_sanpham.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
        }

        private void Tex_gianhap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tex_soluong.Text))
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tex_gianhap_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxGiaNhap.Text))
            {
                long gN = long.Parse(textBoxGiaNhap.Text);
                long gB = gN + (gN / 100 * 20);
                textBoxGiaBan.Text = gB.ToString();
            }
        }

        private void Pan_grid_ControlAdded(object sender, ControlEventArgs e)
        {
            RefreshData();
        }

        private void But_closepan_Click(object sender, EventArgs e)
        {
            panelChiTiet.Visible = false;
        }
    }
}
