using milk_sales_manager.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace milk_sales_manager.controls.extra_controls
{
    public partial class NhaSanXuatUC : UserControl
    {
        public event EventHandler BackButtonClicked;

        public NhaSanXuatUC()
        {
            InitializeComponent();
        }

        private void NhaSanXuatUC_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();

                dat_nhasanxuat.Columns["maNhaSanXuat"].Visible = false;
                dat_nhasanxuat.Columns["tenNhaSanXuat"].HeaderText = "Tên nhà sản xuất";
                dat_nhasanxuat.Columns["dienThoai"].HeaderText = "Số điện thoại";
                dat_nhasanxuat.Columns["diaChi"].HeaderText = "Địa chỉ";
                dat_nhasanxuat.Columns["sanPhams"].Visible = false;

                dat_nhasanxuat.Columns["maNhaSanXuat"].Width = 256;
                dat_nhasanxuat.Columns["tenNhaSanXuat"].Width = 256;
                dat_nhasanxuat.Columns["dienThoai"].Width = 256;
                dat_nhasanxuat.Columns["diaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadData()
        {
            DBEntities vinamilkEntities = new DBEntities();
            NhaSanXuat nha = new NhaSanXuat();
            List<NhaSanXuat> nhas = vinamilkEntities.NhaSanXuats.ToList();
            nhas.Add(nha);
            dat_nhasanxuat.DataSource = nhas;
        }

        private void But_back_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, e);
        }

        private void Dat_nhasanxuat_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dat_nhasanxuat.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
            dat_nhasanxuat.Columns["stt"].Width = 64;
        }

        private void Dat_nhasanxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && dat_nhasanxuat.Columns[e.ColumnIndex].Name == "luu" && e.RowIndex >= 0)
                {
                    NhaSanXuat nha = new NhaSanXuat
                    {
                        maNhaSanXuat = dat_nhasanxuat["maNhaSanXuat", e.RowIndex].Value?.ToString() ?? string.Empty,
                        tenNhaSanXuat = dat_nhasanxuat["tenNhaSanXuat", e.RowIndex].Value?.ToString() ?? string.Empty,
                        dienThoai = dat_nhasanxuat["dienThoai", e.RowIndex].Value?.ToString() ?? string.Empty,
                        diaChi = dat_nhasanxuat["diaChi", e.RowIndex].Value?.ToString() ?? string.Empty
                    };

                    using (DBEntities vnm = new DBEntities())
                    {
                        string maNhaSanXuat = "sx" + (nha.tenNhaSanXuat.Length >= 5 ? nha.tenNhaSanXuat.Trim().Replace(" ", "").Substring(0, 5) : nha.tenNhaSanXuat) + DateTime.Now.ToString("fff");

                        RegexInput reg = new RegexInput();
                        string result = reg.RemoveVietnameseMarks(maNhaSanXuat.ToLower());

                        NhaSanXuat nh = new NhaSanXuat
                        {
                            maNhaSanXuat = result,
                            tenNhaSanXuat = nha.tenNhaSanXuat,
                            dienThoai = nha.dienThoai,
                            diaChi = nha.diaChi
                        };

                        if (nh.maNhaSanXuat.Length < 10)
                        {
                            throw new Exception("Tên của nhà sản xuất không hợp lệ!");
                        }
                        else if (nh.dienThoai.Length < 10)
                        {
                            throw new Exception("Số điện thoại không hợp lệ!");
                        }
                        else if (nh.diaChi.Length < 10)
                        {
                            throw new Exception("Địa chỉ không hợp lệ!");
                        }

                        NhaSanXuat nhaSanXuat = vnm.NhaSanXuats.FirstOrDefault(n => n.maNhaSanXuat == nha.maNhaSanXuat);

                        if (nhaSanXuat == null)
                        {
                            vnm.NhaSanXuats.Add(nh);
                            vnm.SaveChanges();
                            MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            nhaSanXuat.tenNhaSanXuat = nha.tenNhaSanXuat;
                            nhaSanXuat.dienThoai = nha.dienThoai;
                            nhaSanXuat.diaChi = nha.diaChi;
                            vnm.SaveChanges();
                            MessageBox.Show("Đã lưu thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        LoadData();
                    }
                }

                if (e.ColumnIndex >= 0 && dat_nhasanxuat.Columns[e.ColumnIndex].Name == "xoa" && e.RowIndex >= 0)
                {
                    if (dat_nhasanxuat.Rows[e.RowIndex].Cells["maNhaSanXuat"].Value == null)
                    {
                        return;
                    }

                    string nam = dat_nhasanxuat.Rows[e.RowIndex].Cells["tenNhaSanXuat"].Value.ToString();

                    if (MessageBox.Show("Nhà sản xuất \"" + nam + "\" sẽ bị xóa!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        using (var vnm = new DBEntities())
                        {
                            string id = dat_nhasanxuat.Rows[e.RowIndex].Cells["maNhaSanXuat"].Value.ToString();

                            var nha = vnm.NhaSanXuats.FirstOrDefault(n => n.maNhaSanXuat == id);

                            if (nha != null)
                            {
                                vnm.NhaSanXuats.Remove(nha);
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

        private void Dat_nhasanxuat_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Phone_Keypress);

            if (dat_nhasanxuat.CurrentCell.ColumnIndex == 3)
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress += new KeyPressEventHandler(Phone_Keypress);
                }
            }
        }

        private void Phone_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
