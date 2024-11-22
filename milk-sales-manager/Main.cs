﻿using milk_sales_manager.controls;
using milk_sales_manager.modules;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace milk_sales_manager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private LoggedInUser _loggedInUser = new LoggedInUser();

        private void Main_Load(object sender, EventArgs e)
        {
            CheckLogin(sender, e);

            ButtonThanhToan_Click(sender, e);
            buttonThanhToan.BackColor = Color.DeepSkyBlue;
        }

        private void CheckLogin(object sender, EventArgs e)
        {
            _loggedInUser = _loggedInUser.CheckLogin(this);
            if (_loggedInUser == null) return;
            
            if (_loggedInUser.Role.Contains("nhanvien"))
            {
                but_khachhang.Visible = false;
                but_nhanvien.Visible = false;
                but_thongke.Visible = false;
            }
            else
            {
                but_khachhang.Visible = true;
                but_nhanvien.Visible = true;
                but_thongke.Visible = true;
            }
        }

        private void ButtonThanhToan_Click(object sender, EventArgs e)
        {
            UserControl tha = new ThanhToanUC(_loggedInUser);
            AddControl(tha, sender);
        }

        private void AddControl(UserControl uc, object se)
        {
            if (pan_container.Controls.Count > 0)
            {
                var currentControl = pan_container.Controls[0] as UserControl;
                if (uc.Tag == currentControl?.Tag)
                    return;

                if (currentControl != null)
                {
                    pan_container.Controls.Remove(currentControl);
                    currentControl.Dispose();
                }
            }

            pan_container.Controls.Add(uc);
            uc.BackColor = Color.MintCream;
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();

            if (!(se is Button btn)) return;
            
            foreach (Button preBut in pan_navigator.Controls)
                preBut.BackColor = Color.MintCream;
            btn.BackColor = Color.DeepSkyBlue;
        }

        private void But_sanpham_Click(object sender, EventArgs e)
        {
            UserControl san = new SanPhamUC(_loggedInUser);
            AddControl(san, sender);
        }

        private void But_nhanvien_Click(object sender, EventArgs e)
        {
            UserControl nha = new NhanVienUC();
            AddControl(nha, sender);
        }

        private void But_khachhang_Click(object sender, EventArgs e)
        {
            UserControl kha = new KhachHangUC();
            AddControl(kha, sender);
        }

        private void But_thongke_Click(object sender, EventArgs e)
        {
            UserControl tho = new ThongKeUC();
            AddControl(tho, sender);
        }

        private void But_tuychon_Click(object sender, EventArgs e)
        {
            var tuy = new TuyChonUC(this, _loggedInUser);
            tuy.Logout += CheckLogin;
            tuy.ThanhToanClick += ButtonThanhToan_Click;

            AddControl(tuy, sender);
        }
    }
}
