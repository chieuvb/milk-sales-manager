using milk_sales_manager.controls.extra_controls;
using milk_sales_manager.models;
using milk_sales_manager.modules;
using milk_sales_manager.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace milk_sales_manager.controls
{
    public partial class NhanVienUC : UserControl
    {
        public NhanVienUC()
        {
            InitializeComponent();
            imageProcess = new ImageProcess(false, cacheImage);
        }

        readonly Dictionary<string, Image> cacheImage = new Dictionary<string, Image>();
        readonly ImageProcess imageProcess;
        readonly NhanVien nhanVien = new NhanVien();
        List<ChucVu> chucVus = new List<ChucVu>();

        private void NhanVienUC_Load(object sender, EventArgs e)
        {
            panelRight.Visible = false;

            RefreshData();
        }

        private void RefreshData()
        {
            comboBoxChucVu.Items.Clear();

            using (Entities vinamilkEntities = new Entities())
            {
                dataGridViewNhanVien.DataSource = vinamilkEntities.NhanViens.AsNoTracking().ToList();

                chucVus = vinamilkEntities.ChucVus.AsNoTracking().ToList();
            }

            foreach (ChucVu chu in chucVus)
            {
                comboBoxChucVu.Items.Add(chu.tenChucVu);
            }
        }

        private void DataGridViewNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewNhanVien.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
        }

        private void DataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                panelRight.Visible = true;
                pictureBoxNhanVien.SizeMode = PictureBoxSizeMode.Zoom;

                nhanVien.maNhanVien = dataGridViewNhanVien["maNhanVienDataGridViewTextBoxColumn", e.RowIndex].Value.ToString();
                NhanVien nhan = new NhanVien();
                string tenCV = string.Empty;

                using (Entities vinamilkEntities = new Entities())
                {
                    nhan = vinamilkEntities.NhanViens.AsNoTracking().FirstOrDefault(n => n.maNhanVien == nhanVien.maNhanVien);
                    tenCV = vinamilkEntities.ChucVus.AsNoTracking().FirstOrDefault(c => c.maChucVu == nhan.maChucVu).tenChucVu;
                }

                textBoxHoTen.Text = nhan.tenNhanVien;
                if (nhan.gioiTinh)
                    comboBoxGioiTinh.SelectedIndex = 0;
                else
                    comboBoxGioiTinh.SelectedIndex = 1;

                dateTimePickerNgaySinh.Value = nhan.ngaySinh;
                textBoxDienThoai.Text = nhan.soDienThoai;
                textBoxEmail.Text = nhan.email;
                textBoxDiaChi.Text = nhan.diaChi;
                textBoxKinhNhiem.Text = nhan.kinhNghiem;

                foreach (var com in comboBoxChucVu.Items)
                {
                    if (com.ToString() == tenCV)
                    {
                        comboBoxChucVu.SelectedItem = com;
                        break;
                    }
                }

                imageProcess.LoadAndCacheImage(nhan.hinhAnh.Trim(), cacheImage);
                pictureBoxNhanVien.Image = cacheImage.ContainsKey(nhan.hinhAnh.Trim()) ? cacheImage[nhan.hinhAnh.Trim()] : cacheImage["no-image"];
            }
        }

        private void PictureBoxNhanVien_DoubleClick(object sender, EventArgs e)
        {
            pictureBoxNhanVien.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxNhanVien.Image = imageProcess.LoadImageToPictureBox();
        }

        private void ButtonThemNhanVien_Click(object sender, EventArgs e)
        {
            panelRight.Visible = true;

            foreach (Control con in panelRight.Controls)
            {
                switch (con)
                {
                    case TextBox textBox:
                        textBox.Clear();
                        break;
                    case ComboBox comboBox:
                        comboBox.SelectedIndex = -1;
                        break;
                    case DateTimePicker dateTimePicker:
                        dateTimePicker.Value = DateTime.Now;
                        break;
                }
            }

            pictureBoxNhanVien.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxNhanVien.Image = Resources.icons8_add_image_96;
            textBoxHoTen.Focus();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string result = ValidateInputs();

                if (result == "success")
                {
                    using (Entities vinamilkEntities = new Entities())
                    {
                        NhanVien existingNhanVien = vinamilkEntities.NhanViens.FirstOrDefault(n => n.maNhanVien == nhanVien.maNhanVien);
                        if (existingNhanVien == null)
                            AddNewNhanVien(vinamilkEntities);
                        else
                            UpdateNhanVien(vinamilkEntities, existingNhanVien);
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
                RegexInput regex = new RegexInput();

                if (string.IsNullOrEmpty(textBoxHoTen.Text))
                    return "Bạn chưa nhập tên!";
                else if (comboBoxChucVu.SelectedIndex < 0)
                    return "Chức vụ không hợp lệ!";
                else if (comboBoxGioiTinh.SelectedIndex < 0)
                    return "Giới tính không hợp lệ!";
                else if (dateTimePickerNgaySinh.Value > DateTime.Now.AddYears(-18))
                    return "Người này chưa đủ 18 tuổi!";
                else if (string.IsNullOrEmpty(textBoxDienThoai.Text) || !regex.ValidatePhoneNumber(textBoxDienThoai.Text))
                    return "Số điện thoại không hợp lệ!";
                else if (string.IsNullOrEmpty(textBoxEmail.Text) || !regex.ValidateEmail(textBoxEmail.Text))
                    return "Email không hợp lệ!";
                else if (string.IsNullOrEmpty(textBoxDiaChi.Text))
                    return "Địa chỉ không hợp lệ!";
                else if (string.IsNullOrEmpty(textBoxKinhNhiem.Text))
                    return "Kinh nghiệm không hợp lệ!";
                else
                    return "success";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "fail";
            }
        }

        private void AddNewNhanVien(Entities vinamilkEntities)
        {
            try
            {
                NhanVien nhanVien = CreatNhanVienObject(vinamilkEntities);
                TaiKhoan taiKhoan = CreateTaiKhoanObject(nhanVien);

                vinamilkEntities.NhanViens.Add(nhanVien);
                vinamilkEntities.TaiKhoans.Add(taiKhoan);
                vinamilkEntities.SaveChanges();

                RefreshData();

                panelRight.Visible = false;
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private NhanVien CreatNhanVienObject(Entities vinamilkEntities)
        {
            GenerateString gen = new GenerateString();

            string maNhanVien = gen.StringID("nv", textBoxHoTen.Text);
            string maChucVu = string.Empty;
            string hinhAnh = imageProcess.SaveAndCacheImage(maNhanVien, pictureBoxNhanVien.Image, cacheImage);

            maChucVu = vinamilkEntities.ChucVus.AsNoTracking().FirstOrDefault(c => c.tenChucVu == comboBoxChucVu.SelectedItem.ToString()).maChucVu;

            NhanVien nhanVien = new NhanVien
            {
                maNhanVien = maNhanVien,
                maChucVu = maChucVu,
                tenNhanVien = textBoxHoTen.Text.Trim(),
                hinhAnh = hinhAnh,
                gioiTinh = comboBoxGioiTinh.SelectedIndex < 1,
                ngaySinh = dateTimePickerNgaySinh.Value,
                diaChi = textBoxDiaChi.Text,
                soDienThoai = textBoxDienThoai.Text,
                email = textBoxEmail.Text,
                kinhNghiem = textBoxKinhNhiem.Text
            };

            return nhanVien;
        }

        private TaiKhoan CreateTaiKhoanObject(NhanVien nhanVien)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(nhanVien.maNhanVien);

            using (SHA512 sha3 = new SHA512CryptoServiceProvider())
            {
                byte[] hashBytes = sha3.ComputeHash(bytes);
                string hashPass = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();

                TaiKhoan taiKhoan = new TaiKhoan
                {
                    maNhanVien = nhanVien.maNhanVien,
                    matKhau = hashPass,
                    quyenHan = "imnhanvien",
                    trangThai = true
                };

                return taiKhoan;
            }
        }

        private void UpdateNhanVien(Entities vinamilkEntities, NhanVien existingNhanVien)
        {
            try
            {
                string maNhanVien = existingNhanVien.maNhanVien;
                string maChucVu = string.Empty;
                string hinhAnh = maNhanVien;

                imageProcess.UpdateImage(hinhAnh, pictureBoxNhanVien.Image, cacheImage);
                maChucVu = vinamilkEntities.ChucVus.AsNoTracking().FirstOrDefault(c => c.tenChucVu == comboBoxChucVu.SelectedItem.ToString()).maChucVu;

                existingNhanVien.tenNhanVien = textBoxHoTen.Text.Trim();
                existingNhanVien.maChucVu = maChucVu;
                existingNhanVien.hinhAnh = hinhAnh;
                existingNhanVien.gioiTinh = comboBoxGioiTinh.SelectedIndex < 1;
                existingNhanVien.ngaySinh = dateTimePickerNgaySinh.Value;
                existingNhanVien.diaChi = textBoxDiaChi.Text;
                existingNhanVien.soDienThoai = textBoxDienThoai.Text;
                existingNhanVien.email = textBoxEmail.Text;
                existingNhanVien.kinhNghiem = textBoxKinhNhiem.Text;

                vinamilkEntities.SaveChanges();

                RefreshData();

                panelRight.Visible = false;
                MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có thực sự muốn xóa nhân viên: \"" + textBoxHoTen.Text + "\"?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    using (Entities vinamilkEntities = new Entities())
                    {
                        NhanVien nhanVienForDelete = vinamilkEntities.NhanViens.FirstOrDefault(n => n.maNhanVien == nhanVien.maNhanVien);

                        if (nhanVienForDelete != null)
                        {
                            imageProcess.DeleteImage(nhanVien.maNhanVien, cacheImage);

                            vinamilkEntities.NhanViens.Remove(nhanVienForDelete);
                            vinamilkEntities.SaveChanges();

                            RefreshData();

                            panelRight.Visible = false;
                            MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            panelRight.Visible = false;
        }

        private void TextBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTimKiem.Text == "Nhập mã nhân viên hoặc tên nhân viên!")
                    return;

                RegexInput reg = new RegexInput();

                using (Entities vinamilkEntities = new Entities())
                {
                    string keyword = reg.RemoveVietnameseMarks(textBoxTimKiem.Text.ToLower());

                    List<NhanVien> nhanViens = vinamilkEntities.NhanViens.ToList();

                    List<NhanVien> filteredNhanViens = nhanViens.Where(n => reg.RemoveVietnameseMarks(n.tenNhanVien.ToLower()).Contains(keyword) || n.maNhanVien.Contains(keyword)).ToList();

                    dataGridViewNhanVien.DataSource = filteredNhanViens;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxTimKiem_Enter(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "Nhập mã nhân viên hoặc tên nhân viên!")
            {
                textBoxTimKiem.Clear();
                textBoxTimKiem.ForeColor = Color.Black;
                textBoxTimKiem.Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }

        private void TextBoxTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTimKiem.Text))
            {
                textBoxTimKiem.Text = "Nhập mã nhân viên hoặc tên nhân viên!";
                textBoxTimKiem.ForeColor = Color.Gray;
                textBoxTimKiem.Font = new Font("Arial", 12, FontStyle.Italic);
            }
        }

        private void ButtonChucVu_Click(object sender, EventArgs e)
        {
            dataGridViewNhanVien.Visible = false;
            panelSearch.Visible = false;
            panelRight.Visible = false;

            ChucVuUC chuc = new ChucVuUC();
            chuc.BackButtonClicked += BackToParentPage;
            Controls.Add(chuc);
            chuc.Dock = DockStyle.Fill;
            chuc.BringToFront();
        }

        private void BackToParentPage(object sender, EventArgs e)
        {
            Controls.Remove(sender as Control);

            dataGridViewNhanVien.Visible = true;
            panelSearch.Visible = true;
        }
    }
}
