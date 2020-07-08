using System.Collections.Specialized;
using System.Windows.Forms;

namespace POOP2.Classes.Ex09
{
    public abstract class Vehicle
    {

        private string name;
        private string color;
        private int year;
        private double price;

        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        public void Print()
        {
            MessageBox.Show(string.Format("Nome: {0}\nAno: {1}\nPreco: {2}\nCor: {3}", Name, Year, Price, Color));
        }

        public void Start()
        {
            MessageBox.Show("Ligando o carro...");
        }

    }
}
