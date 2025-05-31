using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Employee
    {
        public string FirstName { get;private set; }
        public string LastName { get;private set; }
        public void SetName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("First name and last name cannot be empty.");
            }
            FirstName = firstName;
            LastName = lastName;
        }
        public  DateTime DateOfBirth { get;private set; }
        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth > DateTime.Now)
            {
                throw new ArgumentException("Date of birth cannot be in the future.");
            }
            else if (dateOfBirth < new DateTime(1950, 1, 1))
            {
                throw new ArgumentException("Date of birth cannot be before the year 1900.");
            }
            DateOfBirth = dateOfBirth;
        }
        public decimal BasicSalary { get;private set; }
        public void SetBasicSalary(decimal basicSalary)
        {
            if (basicSalary < 0)
            {
                throw new ArgumentException("Basic salary cannot be negative.");
            }
            BasicSalary = basicSalary;
        }
        public int TaxParcentage { get; set; }


    }
}
