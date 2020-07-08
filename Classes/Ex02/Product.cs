using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOP2.Classes.Ex02
{
    public class Product
    {

        private string name;
        private double price;
        private int quantity;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public void Sell(int quantity)
        {
            if (quantity > this.quantity)
                MessageBox.Show("Quantidade acima do permitido");
            else
                this.quantity -= quantity;
        }

        public void Print()
        {
            MessageBox.Show(string.Format("Nome do Produto: {0}\nPreço: {1}\nQuantidade:{2}", Name, Price, Quantity));
        }
    }
}
