﻿using POOP2.Classes;
using POOP2.Classes.Ex01;
using System;
using System.Windows.Forms;

namespace POOP2.Formularios
{
    public partial class Ex01Form : Form
    {
        private Usuario _usuario;

        public Ex01Form()
        {
            InitializeComponent();
            _usuario = new Usuario();
        }

        private void userSaveBtn_Click(object sender, EventArgs e)
        {
            _usuario.Name = firstNameTxb.Text;
            _usuario.LastName = lastNameTxb.Text;
        }

        private void saveCreditCardTxb_Click(object sender, EventArgs e)
        {
            CreditCard credit = new CreditCard();
            credit.CVV = int.Parse(cvvNumberTxb.Text);
            credit.Expiration = dateTxb.Value;
            credit.CardNumber = cardNumberTxb.Text;
            credit.CreditLimit = 2000;
            _usuario.Card = credit;
            MessageBox.Show("Seu limite foi redefinido para: " + credit.CreditLimit);
        }

        private void userPrintBtn_Click(object sender, EventArgs e)
        {
            _usuario.Print();
        }

        private void printCreditCardTxb_Click(object sender, EventArgs e)
        {
            if (_usuario.Card == null)
                MessageBox.Show("Não foi adicionado cartão de crédito ainda!");
            _usuario.Card?.Print();
        }

        private void userBuyTxb_Click(object sender, EventArgs e)
        {
            InputDialog id = new InputDialog();
            id.ShowDialog();
            if (double.TryParse(id.Valor, out double preco))
                _usuario.Comprar(preco);
            else
                MessageBox.Show("Entrada inválida");
        }

        private void creditCardIncreaseLimitTxb_Click(object sender, EventArgs e)
        {
            InputDialog id = new InputDialog();
            id.ShowDialog();
            double.TryParse(id.Valor, out double valor);
            _usuario.Card.IncreaseLimit(valor);
        }
    }
}
