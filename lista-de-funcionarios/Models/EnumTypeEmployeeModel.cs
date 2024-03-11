using System;


namespace ListaDeFuncionarios.Models
{
    internal enum EnumTypeEmployeeModel
    {
        CLT, 
        Tercerizado
    }
    internal class Employee
    {
        public EnumTypeEmployeeModel Type { get; set; }
    }
}
