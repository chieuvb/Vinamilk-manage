using GUI_vinamilk.Controls;
using System.Windows.Forms;

namespace GUI_vinamilk.Modul
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
