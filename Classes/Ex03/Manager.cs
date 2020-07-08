using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOP2.Classes.Ex03
{
    public class Manager
    {
        private string _name;
        private double _salary;
        private Department _department;

        public string Name { get => _name; set => _name = value; }
        public double Salary { get => _salary; set => _salary = value; }
        public Department Department { get => _department; set => _department = value; }

        public Manager()
        {
            this.Department = new Department();
        }

        public void Print()
        {
            MessageBox.Show($"Nome: {_name}\nSalário: {_salary}");
        }

        public void Hire()
        {
            if(_department.MaxEmployeeAmount == 0)
            {
                MessageBox.Show("O número máximo de funcionários é 0! Edite o departamento.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_department.CanHire()) {
                this.Department.EmployeesCount++;
                MessageBox.Show("Funcionário contratado com sucesso!");
            } else {
                MessageBox.Show("Departamento lotado! Demita um funcionário antes de contratar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Fire()
        {
            if (_department.EmployeesCount > 0) {
                this.Department.EmployeesCount--;

                MessageBox.Show("Funcionário demitido com sucesso!");
            } else {
                MessageBox.Show("Departamento vazio! Não foi possível demitir.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
