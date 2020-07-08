using POOP2.Classes;
using POOP2.Formularios;
using System;
using System.Windows.Forms;

namespace POOP2
{
    public partial class Form1 : Form
    {

        private Usuario usuario;

        public Form1()
        {
            InitializeComponent();
            usuario = new Usuario();
        }

        private void btnExercisesClick(object sender, EventArgs e)
        {
            Form form = null;
            switch ((sender as Button).Name)
            {
                case "btnEx1":
                    form = new Ex01Form();
                    break;
                default:
                    break;
            }
            // Chamando o form com null safety check
            form?.Show();
        }
    }
}
