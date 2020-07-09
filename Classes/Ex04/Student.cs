using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOP2.Classes.Ex04
{
    public class Student
    {
        private string _name;
        private double _grade;
        private Professor _professor;

        public string Name { get => _name; set => _name = value; }
        public double Grade { get => _grade; set => _grade = value; }
        public Professor Professor { get => _professor; set => _professor = value; }

        public Student()
        {

        }

        public Student(string name, Professor professor)
        {
            Name = name;
            Professor = professor;

        }

        public void Print()
        {
            MessageBox.Show($"Nome do aluno: {_name}\nNota: {_grade}");
        }

        public void MakeTest()
        {
            this.Grade = Professor.GiveGrade();
        }
    }
}
