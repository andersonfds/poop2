using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOP2.Classes.Ex05
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _city;
        private Car _car;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string City { get => _city; set => _city = value; }
        public Car Car { get => _car; set => _car = value; }

        public Person()
        {
            Car = new Car();
        }

        public void Print()
        {
            MessageBox.Show($"Nome: {_firstName}\n" +
                $"Sobrenome: {_lastName}\n" +
                $"Cidade: {_city}");
        }

        public void Travel()
        {
            if (!Car.Started)
                MessageBox.Show("Ligue o carro antes de viajar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Car.GasAmount <= 0 || Car.GasAmount - Car.GasCapacity * 0.3F < 0)
                MessageBox.Show("Gasolina insuficiente! Abasteça o carro antes de viajar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Car.GasAmount -= Car.GasCapacity * 0.3F;
                MessageBox.Show("Viagem realizada com sucesso! Parabéns!");
            }
        }

    }
}
