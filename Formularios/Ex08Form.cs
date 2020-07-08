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
        }

        // Print
        private void button3_Click(Object sender, EventArgs e)
        {
            if (_user == null)
            {
                MessageBox.Show("Cadastre o usuário antes de imprimir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _user.Print();
        }

        // Login
        private void button1_Click(Object sender, EventArgs e)
        {
            if (_user.Email != txtEmail.Text || _user == null)
            {
                MessageBox.Show("Usuário não encontrado! Tente novamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (_user.Password != txtPassword.Text)
            {
                MessageBox.Show("Senha inválida! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                _user.Login();
                MessageBox.Show("Usuário logado com sucesso!");
            }
        }

        // Cadastro
        private void button2_Click(Object sender, EventArgs e)
        {
            _user = new User();
            _user.Register(txtRegisterName.Text, txtRegisterEmail.Text, txtRegisterPassword.Text);
            MessageBox.Show("Usuário cadastrado com sucesso!");
        }

        // Publicar
        private void button4_Click(Object sender, EventArgs e)
        {
            if (_user == null)
            {
                MessageBox.Show("Você precisa estar logado para fazer a publicação!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var post = new Post();
            post.WriteNew(txtTitle.Text, txtContent.Text);
            _user.Posts.Add(post);
            txtTitle.Text = null;
            txtContent.Text = null;
            MessageBox.Show("Publicação realizada com sucesso!");

        }

        // Ver posts
        private void button5_Click(Object sender, EventArgs e)
        {
            PostsForm postsForm = new PostsForm(_user.Posts);
            postsForm.Show();
        }
    }
}
