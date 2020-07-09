using POOP2.Classes.Ex07;
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
    public partial class Ex07Form : Form
    {
        private Book book;

        public Ex07Form()
        {
            InitializeComponent();
            book = new Book();
            book.Chapters = new List<Chapter>();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            book.Print();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            book.Title = txbBookName.Text;
            book.Publisher = txbPublisherName.Text;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Chapter c = new Chapter();
            c.Title = txbChapterTitle.Text;
            c.PageCount = (int)txbChapterNumber.Value;
            lbxChapters.Items.Add(c.Title);
            book.Chapters.Add(c);
        }

        private void btnTurnPage_Click(object sender, EventArgs e)
        {
            if (lbxChapters.SelectedIndex >= 0)
                book.Chapters[lbxChapters.SelectedIndex].TurnPage();
            else
                MessageBox.Show("Não há capitulos selecionados");
        }

        private void btnChapters_Click(object sender, EventArgs e)
        {
            if (book.Chapters.Count > 0)
                book.TurnChapter();
            else
                MessageBox.Show("Não há capitulos");
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (lbxChapters.SelectedIndex >= 0)
                book.Chapters[lbxChapters.SelectedIndex].Print();
            else
                MessageBox.Show("Não há capitulos selecionados");
        }
    }
}
