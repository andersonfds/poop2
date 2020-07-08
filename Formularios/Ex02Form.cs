using POOP2.Classes.Ex02;
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
    public partial class Ex02Form : Form
    {
        private Store loja;
        private bool isBroken = false;

        public Ex02Form()
        {
            InitializeComponent();
            loja = new Store();
            loja.Products = new List<Product>();
        }

        private void btnStoreSave_Click(object sender, EventArgs e)
        {
            loja.Name = txbStoreName.Text;
            loja.Address = txbStoreAddress.Text;
        }

        private void btnStorePrint_Click(object sender, EventArgs e)
        {
            loja.Print();
        }

        private void btnIsClosed_Click(object sender, EventArgs e)
        {
            string status = loja.IsCLosed() ? "fechada" : "aberta";
            if (isBroken) status = "arrombada";
            MessageBox.Show(string.Format("A loja está {0}!", status));
        }

        private void btnStoreBreak_Click(object sender, EventArgs e)
        {
            isBroken = true;
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbProductPrice.Text, out double prodPrice))
            {
                Product product = new Product
                {
                    Name = txbProductName.Text,
                    Quantity = (int)txbQtdAvailable.Value,
                    Price = prodPrice,
                };
                lvwProduct.Items.Add(product.Name);
                loja.Products.Add(product);
            }
            else
                MessageBox.Show("Preço inválido!");
        }

        private void btnProductDetails_Click(object sender, EventArgs e)
        {
            string searchString = lvwProduct.SelectedItem.ToString();
            if (searchString == null)
                MessageBox.Show("Selecione um produto válido!");
            else
            {
                var product = loja.Products.Where(x => searchString.Contains(x.Name)).FirstOrDefault();
                product.Print();
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string searchString = lvwProduct.SelectedItem.ToString();
            if (searchString == null)
                MessageBox.Show("Selecione um produto válido!");
            else
            {
                var product = loja.Products.Where(x => searchString.Contains(x.Name)).FirstOrDefault();
                InputDialog id = new InputDialog();
                id.ShowDialog();
                if (int.TryParse(id.Valor, out int valor)) 
                    product.Sell(valor);
            }
        }
    }
}
