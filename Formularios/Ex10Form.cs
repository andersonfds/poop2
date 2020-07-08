using POOP2.Classes.Ex10;
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
    public partial class Ex10Form : Form
    {
        private Dog animal;

        public Dog Animal { get => animal; set => animal = value; }

        public Ex10Form()
        {
            InitializeComponent();
            animal = new Dog();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            animal.Name = nameTxb.Text;
            animal.Age = int.Parse(ageTxb.Text);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            animal.Print();
        }

        private void emitSoundBtn_Click(object sender, EventArgs e)
        {
            animal.EmitSound();
        }
    }
}
