using milk_sales_manager.models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace milk_sales_manager.controls
{
    public partial class ThongKeUC : UserControl
    {
        public ThongKeUC()
        {
            InitializeComponent();
        }

        private void ThongKeUC_Load(object sender, EventArgs e)
        {
            for (int i = 1976; i <= DateTime.Now.Year; i++)
            {
                comboBoxNam.Items.Add(i);
            }

            dataGridViewThong.Columns.Clear();
            dataGridViewThong.Rows.Clear();

            for (int i = 1; i <= 12; i++)
            {
                dataGridViewThong.Columns.Add("thang" + i, "Tháng " + i.ToString());
                dataGridViewThong.Columns["thang" + i].Width = 128;
            }

            comboBoxNam.SelectedItem = DateTime.Now.Year;

            ButtonDoanhThu_Click(sender, e);
        }

        private void ButtonDoanhThu_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu();
        }

        private void ThongKeDoanhThu()
        {
            dataGridViewThong.Rows.Clear();

            string year = comboBoxNam.SelectedItem.ToString();
            List<DonHang> donHangs = new List<DonHang>();

            using (DBEntities vinamilkEntities = new DBEntities())
            {
                donHangs.AddRange(vinamilkEntities.DonHangs.AsNoTracking().ToList());
            }

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridViewThong);
            row.Height = 32;

            double tienDaBan = 0;

            foreach (DataGridViewColumn column in dataGridViewThong.Columns)
            {
                foreach (DonHang don in donHangs)
                {
                    string columnName = column.Name.Remove(0, 5);
                    if (don.ngayTao.Year.ToString() == year && columnName == don.ngayTao.Month.ToString().Replace("0", ""))
                    {
                        tienDaBan += don.tongTien;
                        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                        row.Cells[int.Parse(columnName.Replace("0", "")) - 1].Value = tienDaBan.ToString("N0", cul) + " VND";
                    }
                }

                tienDaBan = 0;
            }

            dataGridViewThong.Rows.Add(row);
        }

        private void ComboBoxNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThongKeDoanhThu();
        }
    }
}
