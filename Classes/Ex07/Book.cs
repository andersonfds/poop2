using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POOP2.Classes.Ex07
{
    public class Book
    {
        private string title;
        private string publisher;
        private List<Chapter> chapters;

        public string Title { get => title; set => title = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public List<Chapter> Chapters { get => chapters; set => chapters = value; }

        public void Print()
        {
            MessageBox.Show(string.Format("Título: {0}\nEditora: {1}\nCapitulos: {2}\nPáginas: {3}", Title, Publisher, Chapters?.Count, PageCount()));
        }

        public void TurnChapter()
        {
            MessageBox.Show("Capitulo mudado com sucesso");
        }

        public int PageCount()
        {
            return chapters?.Sum(x => x.PageCount) ?? 0;
        }
    }
}
