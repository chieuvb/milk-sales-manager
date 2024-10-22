using milk_sales_manager.controls;
using System.Windows.Forms;

namespace milk_sales_manager.modules
{
    public class LoggedInUser
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public LoggedInUser CheckLogin(Form m)
        {
            FormLogin formLogin = new FormLogin();
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                return new LoggedInUser
                {
                    Username = formLogin.user,
                    Role = formLogin.role,
                };
            }
            else
            {
                m.Close();
                return null;
            }
        }
    }
}
