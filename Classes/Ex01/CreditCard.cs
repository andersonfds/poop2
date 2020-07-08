using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOP2.Classes.Ex01
{
    public class CreditCard
    {
        private string cardNumber;
        private int cvv;
        private DateTime expiration;
        private double creditLimit;

        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public int CVV { get => cvv; set => cvv = value; }
        public DateTime Expiration { get => expiration; set => expiration = value; }

        public double CreditLimit { get => creditLimit; set => creditLimit = value; }

        public void IncreaseLimit(double factor)
        {
            CreditLimit += factor;
        }

        public void Print()
        {
            MessageBox.Show(string.Format("Numero do Cartão: {0}\nData de Expiração: {1}/{2}\nCVV: {3}\nLimite de Crédito: {4}", CardNumber, Expiration.Month, Expiration.Year, CVV, creditLimit));
        }
    }
}
