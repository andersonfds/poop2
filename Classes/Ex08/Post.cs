using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOP2.Classes.Ex08
{
    public class Post
    {
        private string _title;
        private string _content;
        private int _likes;

        public string Title { get => _title; set => _title = value; }
        public string Content { get => _content; set => _content = value; }
        public int Likes { get => _likes; set => _likes = value; }

        public void WriteNew()
        {

        }
        
        public void Like()
        {

        }

        public void Print()
        {
            MessageBox.Show($"Título da publicação: {_title}\nConteúdo: {_content}\nLikes: {_likes}");
        }
    }
}
