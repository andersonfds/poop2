using POOP2.Classes.Ex08;
using System;
using System.Windows.Forms;

namespace POOP2.Formularios
{
    public partial class Ex08Form : Form
    {
        private User _user;

        public Ex08Form()
        {
            InitializeComponent();
            _user = new User();
        }

        // Print
        private void button3_Click(Object sender, EventArgs e)
        {

        }

        // Login
        private void button1_Click(Object sender, EventArgs e)
        {
            if (_user.Email != txtEmail.Text) {
                MessageBox.Show("Usuário não encontrado! Tente novamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (_user.Password != txtPassword.Text) {
                MessageBox.Show("Senha inválida! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                MessageBox.Show("Usuário logado com sucesso!");
            }
        }

        // Cadastro
        private void button2_Click(Object sender, EventArgs e)
        {
            _user.Name = txtRegisterName.Text;
            _user.Email = txtRegisterEmail.Text;
            _user.Password = txtRegisterPassword.Text;
            MessageBox.Show("Usuário cadastrado com sucesso!");
        }
    }
}
