using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee : Person
    {
      
        public decimal Salary { get;private set; }
        public void SetSalary(decimal salary)
        {
            if (salary < 0)
            {
                throw new ArgumentException("Salary cannot be negative.");
            }
            Salary = salary;
        }

    }
}
