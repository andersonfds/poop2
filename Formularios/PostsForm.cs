using POOP2.Classes.Ex08;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOP2.Formularios
{
    public partial class PostsForm : Form
    {
        private List<Post> _posts;

        public PostsForm(List<Post> posts)
        {
            this._posts = posts;
            InitializeComponent();

            foreach (var item in _posts)
            {
                this.listView1.Items.Add($"Título da publicação: {item.Title}\nConteúdo: {item.Content}");
            }
        }

        private void label1_Click(Object sender, EventArgs e)
        {

        }
    }
}
