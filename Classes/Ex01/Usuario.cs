using POOP2.Formularios;
using POOP2.Interfaces;
using System.Windows.Forms;

namespace POOP2.Classes.Ex01
{
    public class Usuario
    {
        private string name;
        private string lastName;
        private string cpf;
        private CreditCard card;

        public string Name { get => name; set => name = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public string CPF { get => cpf; set => cpf = value; }

        public CreditCard Card { get => card; set => card = value; }

        public void Comprar(double preco)
        {
            if (preco == null)
            {
                MessageBox.Show("Valor de compra inválido");
            }
            else if (Card.CreditLimit < preco)
            {
                MessageBox.Show("Não há limite o suficiente");
            }
            else
            {
                Card.CreditLimit -= preco;
                MessageBox.Show("Compra efetuada com sucesso");
            }
        }

        public void Print()
        {
            MessageBox.Show("Nome: " + Name + "\n\n" + "Sobrenome: " + LastName);
        }
    }
}
