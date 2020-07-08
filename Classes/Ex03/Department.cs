using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOP2.Classes.Ex03
{
    public class Department
    {
        private string _description;
        private int _maxEmployeeAmount;
        private int _employeesCount;
        private Manager _manager;

        public string Description { get => _description; set => _description = value; }
        public int MaxEmployeeAmount { get => _maxEmployeeAmount; set => _maxEmployeeAmount = value; }
        public int EmployeesCount { get => _employeesCount; set => _employeesCount = value; }
        public Manager Manager { get => _manager; set => _manager = value; }

        public Department()
        {
            this.MaxEmployeeAmount = 0;
            this.EmployeesCount = 0;
        }

        public void Print()
        {
            MessageBox.Show($"Descrição do departamento: {_description}\n" +
                $"Número de funcionários: {_employeesCount}\n" +
                $"Número máximo de funcionários: {_maxEmployeeAmount}");
        }

        public bool CanHire()
        {
            return _employeesCount < _maxEmployeeAmount;
        }
    }
}
