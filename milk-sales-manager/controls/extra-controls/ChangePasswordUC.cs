using milk_sales_manager.models;
using milk_sales_manager.modules;
using System;
using System.Linq;
using System.Windows.Forms;

namespace milk_sales_manager.controls.extra_controls
{
    public partial class ChangePasswordUC : UserControl
    {
        public event EventHandler LogOut;

        public ChangePasswordUC(LoggedInUser log)
        {
            InitializeComponent();
            loggedInUser = log;
        }

        readonly LoggedInUser loggedInUser;

        private void ChangePasswordUC_Load(object sender, EventArgs e)
        {
            textBoxOldPassword.PasswordChar = '●';
            textBoxNewPassword.PasswordChar = '●';
            textBoxRetypePassword.PasswordChar = '●';

            labelUsername.Text = loggedInUser.Username;
        }

        private void ButtonSaveChange_Click(object sender, EventArgs e)
        {
            string oldPassword = textBoxOldPassword.Text;
            string newPassword = textBoxNewPassword.Text;
            string retypePassword = textBoxRetypePassword.Text;

            try
            {
                if (string.IsNullOrEmpty(oldPassword))
                    throw new Exception("Vui lòng nhập mật khẩu cũ!");
                if (string.IsNullOrEmpty(newPassword))
                    throw new Exception("Vui lòng nhập mật khẩu mới!");
                if (string.IsNullOrEmpty(retypePassword))
                    throw new Exception("Vui lòng nhập lại mật khẩu mới!");
                if (newPassword != retypePassword)
                    throw new Exception("Mật khẩu mới không khớp!");

                using (var vinamilkEntities = new Entities())
                {
                    TaiKhoan taiKhoan = vinamilkEntities.TaiKhoans.FirstOrDefault(t => t.maNhanVien.Trim() == loggedInUser.Username);
                    if (taiKhoan != null)
                    {
                        EncodePassword encodePassword = new EncodePassword();
                        string hashOldPassword = encodePassword.Encode(oldPassword);
                        string hashNewPassword = encodePassword.Encode(newPassword);

                        if (hashOldPassword == taiKhoan.matKhau)
                        {
                            taiKhoan.matKhau = hashNewPassword;
                            vinamilkEntities.SaveChanges();

                            MessageBox.Show("Đổi mật khẩu thành công!\n\nVui lòng đăng nhập lại!", "Thông báo", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogOut?.Invoke(this, e);
                        }
                        else
                        {
                            throw new Exception("Mật khẩu cũ không đúng!");
                        }
                    }
                    else
                        throw new Exception("Không tìm thấy tài khoản \"" + loggedInUser.Username + "\"");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxOldPassword.PasswordChar = '\0';
                textBoxNewPassword.PasswordChar = '\0';
                textBoxRetypePassword.PasswordChar = '\0';
            }
            else
            {
                textBoxOldPassword.PasswordChar = '●';
                textBoxNewPassword.PasswordChar = '●';
                textBoxRetypePassword.PasswordChar = '●';
            }
        }
    }
}
