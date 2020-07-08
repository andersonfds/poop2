using POOP2.Interfaces;
using System;
using System.Windows.Forms;

namespace POOP2.Classes.Ex10
{
    public class Dog : IAnimal
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void EmitSound()
        {
            MessageBox.Show("AU AU");
        }

        public void Print()
        {
            MessageBox.Show(string.Format("Nome: {0}\nIdade: {1}", Name, Age));
        }
    }
}
