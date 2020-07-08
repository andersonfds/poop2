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
    public partial class CommentsForm : Form
    {

        private List<Comment> _comments;

        public CommentsForm()
        {
            InitializeComponent();
        }
        public CommentsForm(List<Comment> comments)
        {
            _comments = comments;
            InitializeComponent();
            _comments.ForEach(x => lbxComments.Items.Add(x.Text));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lbxComments.SelectedIndex >= 0)
            {
                Comment comment = _comments[lbxComments.SelectedIndex];
                comment.Print();
            }
        }

        private void btnCurtir_Click(object sender, EventArgs e)
        {
            if (lbxComments.SelectedIndex >= 0)
            {
                Comment comment = _comments[lbxComments.SelectedIndex];
                comment.Like();
            }
        }
    }
}
