using System.Windows.Forms;

namespace POOP2.Classes.Ex09
{
    public class EletricCar : Vehicle
    {
        private int doors;
        private double eletricRange;

        public int Doors { get => doors; set => doors = value; }
        public double EletricRange { get => eletricRange; set => eletricRange = value; }

        public void PrintEletric()
        {
            MessageBox.Show(string.Format("Nome: {0}\nAno: {1}\nPreco: {2}\nCor: {3}\nPortas: {4}\nKMs por ciclo: {5}", Name, Year, Price, Color, Doors, EletricRange));
        }

        public void Recharge()
        {
            MessageBox.Show("Recarregando...");
        }
    }
}
