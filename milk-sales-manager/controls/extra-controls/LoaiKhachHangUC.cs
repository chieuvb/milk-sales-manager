using milk_sales_manager.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace milk_sales_manager.controls.extra_controls
{
    public partial class LoaiKhachHangUC : UserControl
    {
        public event EventHandler BackButtonClicked;

        public LoaiKhachHangUC()
        {
            InitializeComponent();
        }

        private void LoaiKhachHangUC_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            using (Entities vinamilkEntities = new Entities())
            {
                List<LoaiKhachHang> loaiKhachHangs = vinamilkEntities.LoaiKhachHangs.AsNoTracking().ToList();
                loaiKhachHangs.Add(new LoaiKhachHang());
                dataGridViewLoaiKhachHang.DataSource = loaiKhachHangs;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, e);
        }

        private void DataGridViewLoaiKhachHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewLoaiKhachHang.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
        }

        private void DataGridViewLoaiKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    LoaiKhachHang loaiKhachHang = new LoaiKhachHang
                    {
                        maLoaiKhachHang = dataGridViewLoaiKhachHang["maLoaiKhachHangDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? "",
                        tenLoaiKhachHang = dataGridViewLoaiKhachHang["tenLoaiKhachHangDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? "",
                        moTa = dataGridViewLoaiKhachHang["moTaDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? "",
                        trangThai = true
                    };

                    if (dataGridViewLoaiKhachHang.Columns[e.ColumnIndex].Name == "luu")
                    {
                        if (string.IsNullOrEmpty(loaiKhachHang.maLoaiKhachHang))
                        {
                            string maLoai = GenerateID(loaiKhachHang.tenLoaiKhachHang);

                            using (Entities vinamilkEntities = new Entities())
                            {
                                LoaiKhachHang loai = vinamilkEntities.LoaiKhachHangs.FirstOrDefault(l => l.maLoaiKhachHang == loaiKhachHang.maLoaiKhachHang) ?? new LoaiKhachHang
                                {
                                    maLoaiKhachHang = maLoai,
                                    tenLoaiKhachHang = loaiKhachHang.tenLoaiKhachHang,
                                    moTa = loaiKhachHang.moTa,
                                    trangThai = loaiKhachHang.trangThai
                                };

                                string res = ValidateData(loai);

                                if (res == "success")
                                {
                                    vinamilkEntities.LoaiKhachHangs.Add(loai);
                                    vinamilkEntities.SaveChanges();

                                    RefreshData();

                                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(res, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            using (Entities vinamilkEntities = new Entities())
                            {
                                LoaiKhachHang loai = vinamilkEntities.LoaiKhachHangs.FirstOrDefault(l => l.maLoaiKhachHang == loaiKhachHang.maLoaiKhachHang);

                                if (loai != null)
                                {
                                    loai.tenLoaiKhachHang = loaiKhachHang.tenLoaiKhachHang;
                                    loai.moTa = loaiKhachHang.moTa;
                                    loai.trangThai = loaiKhachHang.trangThai;

                                    vinamilkEntities.SaveChanges();

                                    RefreshData();

                                    MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    else if (dataGridViewLoaiKhachHang.Columns[e.ColumnIndex].Name == "xoa")
                    {
                        if (MessageBox.Show("Loại khách hàng \"" + loaiKhachHang.tenLoaiKhachHang + "\" sẽ bị xóa vĩnh viễn!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            using (Entities vinamilkEntities = new Entities())
                            {
                                LoaiKhachHang loai = vinamilkEntities.LoaiKhachHangs.FirstOrDefault(l => l.maLoaiKhachHang == loaiKhachHang.maLoaiKhachHang);

                                if (loai != null)
                                {
                                    vinamilkEntities.LoaiKhachHangs.Remove(loai);
                                    vinamilkEntities.SaveChanges();

                                    RefreshData();

                                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi cell content click: " + ex.Message);
            }
        }

        private string GenerateID(string ten)
        {
            try
            {
                string tenLoaiKhach = ten.Replace(" ", "") ?? string.Empty;
                string maLoaiKhach = "lk" + (tenLoaiKhach.Length >= 5 ? tenLoaiKhach.Trim().Substring(0, 5) : tenLoaiKhach);

                int remainingLength = 10 - maLoaiKhach.Length;
                if (remainingLength > 0)
                    maLoaiKhach += Path.GetRandomFileName().Replace(".", "").Substring(0, remainingLength);

                RegexInput reg = new RegexInput();
                string result = reg.RemoveVietnameseMarks(maLoaiKhach.ToLower());

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã loại khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private string ValidateData(LoaiKhachHang loaiKhachHang)
        {
            try
            {
                if (loaiKhachHang == null)
                    return "Loại khách hàng không hợp lệ!";
                else if (string.IsNullOrEmpty(loaiKhachHang.maLoaiKhachHang))
                    return "Mã loại khách hàng không hợp lệ!";
                else if (string.IsNullOrEmpty(loaiKhachHang.moTa))
                    return "Mô tả trống!";
                else
                    return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
