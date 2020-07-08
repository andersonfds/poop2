using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POOP2.Classes.Ex07
{
    public class Book
    {
        private string author;
        private string publisher;
        private List<Chapter> chapters;

        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public List<Chapter> Chapters { get => chapters; set => chapters = value; }

        public void Print()
        {
            MessageBox.Show(string.Format("Autor: {0}\nEditora: {1}\nCapitulos: {2}\nPáginas: {3}", Author, Publisher, Chapters.Count, PageCount()));
        }

        public void TurnChapter()
        {
            MessageBox.Show("Capitulo mudado com sucesso");
        }

        public int PageCount()
        {
            return chapters.Sum(x => x.PageCount);
        }
    }
}
