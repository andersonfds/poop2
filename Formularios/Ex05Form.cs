using POOP2.Classes.Ex05;
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
    public partial class Ex05Form : Form
    {
        private Person _person;

        public Boolean IsNullOrWhiteSpace { get; private set; }

        public Ex05Form()
        {
            _person = new Person();
            InitializeComponent();
        }

        private void btnTravel_Click(Object sender, EventArgs e)
        {
            _person.Travel();
            txtGasAmount.Text = _person.Car.GasAmount.ToString("F2") + " Litros";
        }

        private void btnPrintPerson_Click(Object sender, EventArgs e)
        {
            _person.Print();
        }

        private void btnEditPerson_Click(Object sender, EventArgs e)
        {
            _person.FirstName = txtFirstName.Text;
            _person.LastName= txtLastName.Text;
            _person.City = txtCity.Text;
            MessageBox.Show("Pessoa editada com sucesso!");
        }

        private void btnStartCar_Click(Object sender, EventArgs e)
        {
            _person.Car.Start();
            txtStarted.Text = "Ligado";
        }

        private void btnEditCar_Click(Object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCarYear.Text) || String.IsNullOrWhiteSpace(txtGasAmount.Text))
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _person.Car.Model = txtModel.Text;
            _person.Car.Year = int.Parse(txtCarYear.Text);
            _person.Car.GasCapacity = double.Parse(txtGasCapacity.Text);
            MessageBox.Show("Carro editado com sucesso!");
        }

        private void btnFillGas_Click(Object sender, EventArgs e)
        {
            _person.Car.FillGas();
            txtGasAmount.Text = _person.Car.GasAmount.ToString() + " Litros";
        }

        private void btnPrintCar_Click(Object sender, EventArgs e)
        {
            _person.Car.Print();
        }

        private void txtFormat_TextChanged(Object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
