using milk_sales_manager.models;
using milk_sales_manager.modules;
using System;
using System.Linq;
using System.Windows.Forms;

namespace milk_sales_manager.controls
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public string user, role;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '●';
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    throw new Exception("Vui lòng nhập tên tài khoản và mật khẩu phù hợp!");

                using (Entities vinamilkEntities = new Entities())
                {
                    TaiKhoan taiKhoan = vinamilkEntities.TaiKhoans.AsNoTracking().FirstOrDefault(t => t.maNhanVien == username);

                    if (taiKhoan != null)
                    {
                        EncodePassword en = new EncodePassword();
                        string hashPass = en.Encode(password);

                        if (hashPass == taiKhoan.matKhau)
                        {
                            user = taiKhoan.maNhanVien;
                            role = taiKhoan.quyenHan;

                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                            throw new Exception("Tên tài khoản hoặc mật khẩu không đúng!");
                    }
                    else
                        throw new Exception("Tên tài khoản hoặc mật khẩu không đúng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Focus();
            }
        }

        private void TextBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                textBoxPassword.Focus();
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                ButtonLogin_Click(sender, e);
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
                textBoxPassword.PasswordChar = '\0';
            else
                textBoxPassword.PasswordChar = '●';
        }
    }
}
