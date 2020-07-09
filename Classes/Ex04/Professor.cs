using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOP2.Classes.Ex04
{
    public class Professor
    {
        private string _name;
        private string _gradeName;
        private List<Student> _students;

        public string Name { get => _name; set => _name = value; }
        public string GradeName { get => _gradeName; set => _gradeName = value; }
        public List<Student> Students { get => _students; set => _students = value; }

        public Professor()
        {
            this.Students = new List<Student>();
        }

        public void Print()
        {
            MessageBox.Show($"Nome do professor: {_name}\nNome da matéria: {_gradeName}");
        }

        public double GiveGrade()
        {
            Random rnd = new Random();
            return  Math.Round(rnd.NextDouble() * 10, 2);
        }
    }
}
