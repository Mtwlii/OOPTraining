using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }
        public void SetFullName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("First name and last name cannot be empty or whitespace.");
            }
            FirstName = firstName;
            LastName = lastName;
        }
        public DateTime DateOfBirth { get; private set; }
        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth > DateTime.Now )
            {
                throw new ArgumentException("Date of birth cannot be in the future.");
            }else if (dateOfBirth < new DateTime(1950, 1, 1))
            {
                throw new ArgumentException("Date of birth cannot be before the year 1950.");
            }
            DateOfBirth = dateOfBirth;
        }
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
