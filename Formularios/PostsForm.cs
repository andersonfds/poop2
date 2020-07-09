using POOP2.Classes.Ex08;
using System;
using System.Collections.Generic;
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
            _posts.ForEach(x => lbxPosts.Items.Add(x.Title));
        }

        private void btnCurtir_Click(object sender, EventArgs e)
        {
            if (lbxPosts.SelectedIndex >= 0)
            {
                Post selectedPost = _posts[lbxPosts.SelectedIndex];
                selectedPost.Like();
            }

        }

        private void lbxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxPosts.SelectedIndex >= 0)
            {
                Post selectedPost = _posts[lbxPosts.SelectedIndex];
                lblPostTitle.Text = selectedPost.Title;
                lblPostContent.Text = selectedPost.Content;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lbxPosts.SelectedIndex >= 0)
            {
                Post selectedPost = _posts[lbxPosts.SelectedIndex];
                selectedPost.Print();
            }
        }

        private void btnComments_Click(object sender, EventArgs e)
        {
            if (lbxPosts.SelectedIndex >= 0)
            {
                Post selectedPost = _posts[lbxPosts.SelectedIndex];
                CommentsForm cform = new CommentsForm(selectedPost.Comments);
                cform.Show();
            }
        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            if (lbxPosts.SelectedIndex >= 0)
            {
                Post selectedPost = _posts[lbxPosts.SelectedIndex];
                selectedPost.WriteNewComment(new Comment
                {
                    Text= txbComment.Text
                });
                txbComment.Text = "";
            }
        }
    }
}
