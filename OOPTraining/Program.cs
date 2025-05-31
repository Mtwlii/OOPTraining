using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.SetName("Metwally ", "Mohamed");
            employee.SetDateOfBirth ( new DateTime(1990, 1, 1));
            employee.SetBasicSalary(5000.00m);
            employee.TaxParcentage = 20;


            Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}, ");
            Console.WriteLine($"Date of Birth: {employee.DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Basic Salary: {employee.BasicSalary:C}");
            Console.WriteLine($"Tax Percentage: {employee.TaxParcentage}%");
            Console.ReadKey();

        }
    }
}