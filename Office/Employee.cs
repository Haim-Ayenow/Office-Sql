using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    internal class Employee
    {
        public string Name;
        public string BirthDate;
        public string Email;
        public int Salary;

        public Employee(string name, string birthDate, string email, int salary)
        {
            Name = name;
            BirthDate = birthDate;
            Email = email;
            Salary = salary;
        }

    }
}
