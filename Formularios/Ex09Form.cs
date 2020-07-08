using POOP2.Classes.Ex09;
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
    public partial class Ex09Form : Form
    {
        private EletricCar car;

        public Ex09Form()
        {
            InitializeComponent();
            car = new EletricCar();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            car.Color = colorTxb.Text;
            car.Doors = (int)doorCountTxb.Value;
            car.Name = modelTxb.Text;
            double price;
            if (!double.TryParse(priceTxb.Text, out price))
                MessageBox.Show("O preço não é valido");
            else
                car.Price = price;
            car.Year = (int)yearTxb.Value;
            car.EletricRange = (double)eletricRangeTxb.Value;
        }

        private void printParentBtn_Click(object sender, EventArgs e)
        {
            car.Print();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            car.PrintEletric();
        }

        private void startCarBtn_Click(object sender, EventArgs e)
        {
            car.Start();
        }

        private void rechargeBatteriesBtn_Click(object sender, EventArgs e)
        {
            car.Recharge();
        }
    }
}
