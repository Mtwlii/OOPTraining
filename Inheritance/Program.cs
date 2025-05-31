using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            try
            {
                employee.SetFullName("John", "Doe");
                employee.SetDateOfBirth(new DateTime(1960, 1, 1));
                employee.SetSalary(50000m);
                Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}, DOB: {employee.DateOfBirth.ToShortDateString()}, Salary: {employee.Salary:C}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
