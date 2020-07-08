using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOP2.Classes.Ex08
{
    public class User
    {
        private string _name;
        private string _email;
        private string _password;

        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }

        public void Print()
        {
            MessageBox.Show($"Nome: {_name}\nEmail: {_email}\nPassword: {_password}");
        }
    }
}
