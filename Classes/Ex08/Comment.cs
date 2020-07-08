using System.Windows.Forms;

namespace POOP2.Classes.Ex08
{
    public class Comment
    {
        private string text;
        private int likes;

        public string Text { get => text; set => text = value; }
        public int Likes { get => likes; set => likes = value; }

        public void Print()
        {
            MessageBox.Show(string.Format("Comentário: {0}\nCurtidas: {1}", Text, Likes));
        }

        public void Like()
        {
            Likes += 1;
            MessageBox.Show("Curtido com sucesso!");
        }
    }
}
