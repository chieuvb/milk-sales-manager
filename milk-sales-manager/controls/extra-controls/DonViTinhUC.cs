using milk_sales_manager.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace milk_sales_manager.controls.extra_controls
{
    public partial class DonViTinhUC : UserControl
    {
        public event EventHandler BackButtonClicked;

        public DonViTinhUC()
        {
            InitializeComponent();
        }

        private void But_back_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, e);
        }

        private void DonViTinhUC_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadData()
        {
            DBEntities vinamilkEntities = new DBEntities();
            DonVi don = new DonVi();
            List<DonVi> dons = vinamilkEntities.DonVis.ToList();
            dons.Add(don);
            dat_donvi.DataSource = dons;
        }

        private void Dat_donvi_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dat_donvi.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
            dat_donvi.Columns["stt"].Width = 64;
        }

        private void Dat_donvi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && dat_donvi.Columns[e.ColumnIndex].Name == "luu" && e.RowIndex >= 0)
                {
                    DonVi don = new DonVi
                    {
                        maDonVi = dat_donvi["maDonViDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty,
                        tenDonVi = dat_donvi["tenDonViDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty,
                        moTa = dat_donvi["moTaDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty,
                        trangThai = true
                    };
                    using (DBEntities vnm = new DBEntities())
                    {
                        string tenDonViKhongKhoangTrang = don.tenDonVi.Trim().Replace(" ", "");
                        string maDonVi = "dv" + (tenDonViKhongKhoangTrang.Length >= 5 ? tenDonViKhongKhoangTrang.Substring(0, 5) : tenDonViKhongKhoangTrang).PadRight(5, 'v') + DateTime.Now.ToString("fff");

                        RegexInput reg = new RegexInput();
                        string result = reg.RemoveVietnameseMarks(maDonVi.ToLower());

                        DonVi dv = new DonVi
                        {
                            maDonVi = result,
                            tenDonVi = don.tenDonVi,
                            moTa = don.moTa,
                            trangThai = don.trangThai,
                        };


                        if (dv.maDonVi.Length < 10 || dv.maDonVi.Contains("dvvvvvv"))
                        {
                            throw new Exception("Tên đơn vị đo không hợp lệ!");
                        }
                        else if (dv.moTa.Length < 10)
                        {
                            throw new Exception("Mô tả quá ngắn!");
                        }

                        DonVi donVi = vnm.DonVis.FirstOrDefault(n => n.maDonVi == don.maDonVi);

                        if (donVi == null)
                        {
                            vnm.DonVis.Add(dv);
                            vnm.SaveChanges();
                            MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            donVi.tenDonVi = don.tenDonVi;
                            donVi.moTa = don.moTa;
                            donVi.trangThai = don.trangThai;
                            vnm.SaveChanges();
                            MessageBox.Show("Đã lưu thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        LoadData();
                    }
                }

                if (e.ColumnIndex >= 0 && dat_donvi.Columns[e.ColumnIndex].Name == "xoa" && e.RowIndex >= 0)
                {
                    if (dat_donvi.Rows[e.RowIndex].Cells["maDonViDataGridViewTextBoxColumn"].Value == null)
                    {
                        return;
                    }

                    string nam = dat_donvi.Rows[e.RowIndex].Cells["tenDonViDataGridViewTextBoxColumn"].Value.ToString();

                    if (MessageBox.Show("Đơn vị tính \"" + nam + "\" sẽ bị xóa!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        using (var vnm = new DBEntities())
                        {
                            string id = dat_donvi.Rows[e.RowIndex].Cells["maDonViDataGridViewTextBoxColumn"].Value.ToString();

                            var don = vnm.DonVis.FirstOrDefault(n => n.maDonVi == id);

                            if (don != null)
                            {
                                vnm.DonVis.Remove(don);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
