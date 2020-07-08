using POOP2.Interfaces;
using System;
using System.Windows.Forms;

namespace POOP2.Classes.Ex02
{
    public class Dog : IAnimal
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void EmitSound()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            MessageBox.Show("Au Au Au");
        }
    }
}
