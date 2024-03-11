using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeFuncionarios.Models
{
    internal class EmployeeModel
    {
        private long Id { get; set; }

        private string Name { get; set; }

        private int Cpf {  get; set; }

        private DateTime AdmissionDate {  get; set; }

        private double Salary {  get; set; }

        private int EmployeeType = Employee;

    }
}
