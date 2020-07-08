using POOP2.Classes.Ex03;
using System;
using System.Windows.Forms;

namespace POOP2.Formularios
{
    public partial class Ex03Form : Form
    {
        private Manager _manager;
        private Department _department;
        public Ex03Form()
        {
            _manager = new Manager();
            _department = new Department();
            _manager.Department = _department;
            _department.Manager = _manager;
            InitializeComponent();
        }

        private void groupBox1_Enter(Object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Imprimir gerente
        private void button3_Click(Object sender, EventArgs e)
        {
            _manager.Print();
        }

        // Imprimir departamento
        private void button4_Click(Object sender, EventArgs e)
        {
            _department.Print();
        }

        //Contratar
        private void button1_Click(Object sender, EventArgs e)
        {
            _manager.Hire();
        }

        //Demitir
        private void button2_Click(Object sender, EventArgs e)
        {
            _manager.Fire();
        }

        private void button6_Click(Object sender, EventArgs e)
        {

        }
    }
}
