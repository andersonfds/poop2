using System.Windows.Forms;

namespace POOP2.Classes.Ex07
{
    public class Chapter
    {

        private string title;
        private int pageCount;

        public string Title { get => title; set => title = value; }
        public int PageCount { get => pageCount; set => pageCount= value; }

        public void Print()
        {
            MessageBox.Show(string.Format("Titulo: {0}\nPáginas: {1}", Title, PageCount));
        }

        public void TurnPage()
        {
            MessageBox.Show("Página mudada com sucesso!");
        }
    }
}
