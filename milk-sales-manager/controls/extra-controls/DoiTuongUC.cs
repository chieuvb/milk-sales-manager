using milk_sales_manager.models;
using milk_sales_manager.modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace milk_sales_manager.controls.extra_controls
{
    public partial class DoiTuongUC : UserControl
    {
        public event EventHandler BackButtonClicked;

        public DoiTuongUC()
        {
            InitializeComponent();
        }

        private void PhanLoaiHangUC_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khoi dong: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadData()
        {
            using (Entities vinamilkEntities = new Entities())
            {
                List<DoiTuong> doiTuongs = vinamilkEntities.DoiTuongs.ToList();
                doiTuongs.Add(new DoiTuong());
                dat_doituong.DataSource = doiTuongs;
            }
        }

        private void But_back_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, e);
        }

        private void Dat_loaihang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dat_doituong.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
            dat_doituong.Columns["stt"].Width = 64;
        }

        private void Dat_loaihang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dat_doituong.Columns[e.ColumnIndex].Name == "luu")
                    {
                        DoiTuong doi = new DoiTuong
                        {
                            maDoiTuong = dat_doituong["maDoiTuongDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty,
                            tenDoiTuong = dat_doituong["tenDoiTuongDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty,
                            moTa = dat_doituong["moTaDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty,
                            trangThai = true
                        };

                        using (Entities vnm = new Entities())
                        {
                            GenerateString gen = new GenerateString();
                            string maDoiTuong = gen.StringID("dt", doi.tenDoiTuong);

                            DoiTuong dt = new DoiTuong
                            {
                                maDoiTuong = maDoiTuong,
                                tenDoiTuong = doi.tenDoiTuong,
                                moTa = doi.moTa,
                                trangThai = doi.trangThai
                            };

                            if (string.IsNullOrEmpty(dt.tenDoiTuong))
                                throw new Exception("Tên của đối tượng không hợp lệ!");
                            else if (string.IsNullOrEmpty(dt.moTa))
                                throw new Exception("Mô tả không hợp lệ!");

                            DoiTuong doiTuong = vnm.DoiTuongs.FirstOrDefault(n => n.maDoiTuong == doi.maDoiTuong);

                            if (doiTuong == null)
                            {
                                vnm.DoiTuongs.Add(dt);
                                vnm.SaveChanges();
                                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                doiTuong.tenDoiTuong = doi.tenDoiTuong;
                                doiTuong.moTa = doi.moTa;
                                doiTuong.trangThai = doi.trangThai;
                                vnm.SaveChanges();
                                MessageBox.Show("Đã lưu thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            LoadData();
                        }
                    }

                    if (dat_doituong.Columns[e.ColumnIndex].Name == "xoa")
                    {
                        if (dat_doituong.Rows[e.RowIndex].Cells["maDoiTuongDataGridViewTextBoxColumn"].Value == null)
                        {
                            return;
                        }

                        string nam = dat_doituong.Rows[e.RowIndex].Cells["tenDoiTuongDataGridViewTextBoxColumn"].Value.ToString();

                        if (MessageBox.Show("Đối tượng sử dụng \"" + nam + "\" sẽ bị xóa!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            using (var vnm = new Entities())
                            {
                                string id = dat_doituong.Rows[e.RowIndex].Cells["maDoiTuongDataGridViewTextBoxColumn"].Value.ToString();

                                var doi = vnm.DoiTuongs.FirstOrDefault(n => n.maDoiTuong == id);

                                if (doi != null)
                                {
                                    vnm.DoiTuongs.Remove(doi);
                                    vnm.SaveChanges();
                                    LoadData();

                                    MessageBox.Show("Xóa \"" + nam + "\" thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Có lỗi khi xóa \"" + nam + "\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
