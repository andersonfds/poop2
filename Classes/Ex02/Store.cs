using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POOP2.Classes.Ex02
{
    public class Store
    {
        private string name;
        private string address;
        private List<Product> products;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public List<Product> Products { get => products; set => products = value; }

        public void Print()
        {
            int allProducts = Products.Sum(x => x.Quantity);
            MessageBox.Show(string.Format("Nome da Loja: {0}\nEndereço: {1}\nQuantidade de Produtos: {2}\nQuantidade de itens no estoque: {3}", Name, Address, Products.Count, allProducts));
        }

        public bool IsCLosed() => DateTime.Now.Hour <= 8 || DateTime.Now.Hour >= 19;
    }
}
