using milk_sales_manager.models;
using milk_sales_manager.modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace milk_sales_manager.controls.extra_controls
{
    public partial class ChucVuUC : UserControl
    {
        public ChucVuUC()
        {
            InitializeComponent();
        }

        public event EventHandler BackButtonClicked;

        private void ChucVuUC_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi động trang Chức vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshData()
        {
            List<ChucVu> chucVus = new List<ChucVu>();

            using (Entities vinamilkEntities = new Entities())
            {
                chucVus = vinamilkEntities.ChucVus.AsNoTracking().ToList();
            }

            chucVus.Add(new ChucVu());

            dataGridViewChucVu.DataSource = chucVus;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, e);
        }

        private void DataGridViewChucVu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewChucVu.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
        }

        private void DataGridViewChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                try
                {
                    switch (dataGridViewChucVu.Columns[e.ColumnIndex].Name)
                    {
                        case "luu":
                            {
                                string maChucVu = dataGridViewChucVu["maChucVuDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty;
                                string tenChucVu = dataGridViewChucVu["tenChucVuDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty;
                                string moTa = dataGridViewChucVu["moTaDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty;

                                if (!string.IsNullOrEmpty(tenChucVu) && !string.IsNullOrEmpty(moTa))
                                {
                                    using (Entities vinamilkEntities = new Entities())
                                    {
                                        ChucVu chucVu = vinamilkEntities.ChucVus.FirstOrDefault(c => c.maChucVu == maChucVu);

                                        if (chucVu == null)
                                        {
                                            GenerateString gen = new GenerateString();

                                            vinamilkEntities.ChucVus.Add(new ChucVu
                                            {
                                                maChucVu = gen.StringID("cv", tenChucVu),
                                                tenChucVu = tenChucVu,
                                                moTa = moTa,
                                                trangThai = true
                                            });
                                        }
                                        else
                                        {
                                            chucVu.tenChucVu = tenChucVu;
                                            chucVu.moTa = moTa;
                                        }

                                        vinamilkEntities.SaveChanges();

                                        RefreshData();

                                        string res = chucVu == null ? "Thêm" : "Sửa";
                                        MessageBox.Show(res + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else if (string.IsNullOrEmpty(tenChucVu))
                                    throw new Exception("Tên chức vụ không hợp lệ!");
                                else if (string.IsNullOrEmpty(moTa))
                                    throw new Exception("Mô tả không hợp lệ!");
                            }
                            break;
                        case "xoa":
                            {
                                string maChucVu = dataGridViewChucVu["maChucVuDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty;

                                if (string.IsNullOrEmpty(maChucVu))
                                {
                                    throw new Exception("Không tìm thấy chức vụ!");
                                }

                                using (Entities vinamilkEntities = new Entities())
                                {
                                    ChucVu chucVu = vinamilkEntities.ChucVus.FirstOrDefault(c => c.maChucVu == maChucVu);

                                    if (MessageBox.Show("Chức vụ \"" + chucVu.tenChucVu + "\" sẽ bị xóa vĩnh viễn!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                    {
                                        if (chucVu != null)
                                        {
                                            vinamilkEntities.ChucVus.Remove(chucVu);
                                            vinamilkEntities.SaveChanges();

                                            RefreshData();

                                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
