using milk_sales_manager.controls.extra_controls;
using milk_sales_manager.models;
using milk_sales_manager.modules;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace milk_sales_manager.controls
{
    public partial class TuyChonUC : UserControl
    {
        public event EventHandler Logout;
        public event EventHandler ThanhToanClick;

        public TuyChonUC(Form form, LoggedInUser user)
        {
            InitializeComponent();
            mainForm = form;
            loggedInUser = user;
        }

        readonly Form mainForm;
        readonly LoggedInUser loggedInUser;
        readonly Dictionary<string, Image> oneImage = new Dictionary<string, Image>();

        private void TuyChonUC_Load(object sender, EventArgs e)
        {
            buttonBack.SendToBack();
            pictureBoxHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ImageProcess imageProcess = new ImageProcess(false, oneImage);

            using (Entities vinamilkEntities = new Entities())
            {
                NhanVien nhanVien = vinamilkEntities.NhanViens.AsNoTracking().FirstOrDefault(n => n.maNhanVien == loggedInUser.Username);

                if (nhanVien != null)
                {
                    ChucVu chucVu = vinamilkEntities.ChucVus.AsNoTracking().FirstOrDefault(c => c.maChucVu == nhanVien.maChucVu);
                    if (chucVu != null)
                        labelChucVu.Text = chucVu.tenChucVu;
                    else
                        labelChucVu.Text = "null";
                    imageProcess.LoadAndCacheImage(nhanVien.hinhAnh.Trim(), oneImage);
                    pictureBoxHinhAnh.Image = oneImage.ContainsKey(nhanVien.hinhAnh.Trim()) ? oneImage[nhanVien.hinhAnh.Trim()] : oneImage["no-image"];
                    labelName.Text = nhanVien.tenNhanVien;
                }
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đóng ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mainForm.Close();
            }
        }

        private void OpenControl(UserControl userControl)
        {
            panelControl.BringToFront();
            buttonBack.BringToFront();

            panelControl.Controls.Clear();
            userControl.BringToFront();
            panelControl.Controls.Add(userControl);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelContainer.BringToFront();
            buttonBack.SendToBack();
        }

        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordUC chan = new ChangePasswordUC(loggedInUser);
            chan.LogOut += LogOut;
            OpenControl(chan);
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LogOut(sender, e);
            }
        }

        private void LogOut(object sender, EventArgs e)
        {
            loggedInUser.Username = string.Empty;
            loggedInUser.Role = string.Empty;
            Controls.Clear();
            Logout?.Invoke(this, e);
            ThanhToanClick?.Invoke(this, e);
        }
    }
}
