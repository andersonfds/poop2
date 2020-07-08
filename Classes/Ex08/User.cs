using System.Collections.Generic;
using System.Windows.Forms;

namespace POOP2.Classes.Ex08
{
    public class User
    {
        private string _name;
        private string _email;
        private string _password;
        private bool _loggedIn;
        private List<Post> _posts;

        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public bool LoggedIn{ get => _loggedIn; set => _loggedIn = value; }
        public List<Post> Posts{ get => _posts; set => _posts = value; }

        public User()
        {
            this._loggedIn = false;
            this._posts = new List<Post>();
        }

        public void Login()
        {
            this.LoggedIn = true;
        }
        public void Register(string name, string email, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }

        public void Print()
        {
            MessageBox.Show($"Nome: {_name}\nEmail: {_email}\nPassword: {_password}");
        }
    }
}
