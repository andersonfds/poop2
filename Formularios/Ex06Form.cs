using POOP2.Classes.Ex06;
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
    public partial class Ex06Form : Form
    {
        private Club _club;
        public Ex06Form()
        {
            _club = new Club();
            InitializeComponent();
        }

        private void label3_Click(Object sender, EventArgs e)
        {

        }


       

        // Salvar clube
        private void button8_Click(Object sender, EventArgs e)
        {
            this._club.Name = textBox1.Text;
            this._club.Coach = textBox2.Text;
            MessageBox.Show("Clube editado com sucesso!");
        }

        // Imprimir clube
        private void button4_Click(Object sender, EventArgs e)
        {
            _club.Print();
        }

        // Salvar jogador
        private void button7_Click(Object sender, EventArgs e)
        {
            _club.Player.Name = textBox3.Text;
            _club.Player.Age = int.Parse(textBox4.Text);
            _club.Player.Position = textBox5.Text;
            MessageBox.Show("Jogador editado com sucesso!");
        }
        // Imprimir jogador
        private void button6_Click(Object sender, EventArgs e)
        {
            _club.Player.Print();
        }

        // Score
        private void button5_Click(Object sender, EventArgs e)
        {
            _club.Player.Score();
        }

        // Club win
        private void button1_Click(Object sender, EventArgs e)
        {
            _club.Win();
            label9.Text = _club.Wins.ToString();
        }

        // Club draw
        private void button2_Click(Object sender, EventArgs e)
        {
            _club.Draw();
            label10.Text = _club.Draws.ToString();
        }

        // Club defeate
        private void button3_Click(Object sender, EventArgs e)
        {
            _club.Lose();
            label11.Text = _club.Defeats.ToString();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
