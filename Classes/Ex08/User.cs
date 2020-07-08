using System.Windows.Forms;

namespace POOP2.Classes.Ex08
{
    public class User
    {
        private string _name;
        private string _email;
        private string _password;
        private bool _loggedIn;

        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public bool LoggedIn{ get => _loggedIn; set => _loggedIn = value; }

        public void Login()
        {

        }
        public void Register()
        {

        }

        public void Print()
        {
            MessageBox.Show($"Nome: {_name}\nEmail: {_email}\nPassword: {_password}");
        }
    }
}
