using POOP2.Classes.Ex03;
using System;
using System.Windows.Forms;

namespace POOP2.Formularios
{
    public partial class Ex03Form : Form
    {
        private Manager _manager;
        public Ex03Form()
        {
            _manager = new Manager();
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
            _manager.Department.Print();
        }

        //Contratar
        private void button1_Click(Object sender, EventArgs e)
        {
            _manager.Hire();
            label6.Text = _manager.Department.EmployeesCount.ToString();
        }

        //Demitir
        private void button2_Click(Object sender, EventArgs e)
        {
            _manager.Fire();
            label6.Text = _manager.Department.EmployeesCount.ToString();
        }

        //Salvar departamento
        private void button6_Click(Object sender, EventArgs e)
        {
            _manager.Department.Description = textBox3.Text;
            _manager.Department.MaxEmployeeAmount = int.Parse(textBox4.Text);
            MessageBox.Show("Departamento editado com sucesso!");

        }

        //Salvar gerente
        private void button5_Click(Object sender, EventArgs e)
        {
            _manager.Name = textBox1.Text;
            _manager.Salary = double.Parse(textBox2.Text);
            MessageBox.Show("Gerente editado com sucesso!");
        }

        private void textBox2_TextChanged(Object sender, EventArgs e)
        {

        }
    }
}
