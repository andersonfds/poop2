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
    public partial class InputDialog : Form
    {

        private string valor;
        public string Valor { get => valor; set => valor = value; }

        public InputDialog()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Valor = valueTxb.Text;
            Close();
        }
    }
}
