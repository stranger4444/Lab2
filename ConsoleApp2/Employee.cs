using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee
    {
        private string lastName;
        private string firstName;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public void CalculateSalary(string position, int experience)
        {
            double baseSalary = 0;
            if (position == "Percussion")
            {
                baseSalary = 5000;
            }
            else if (position == "Programmer")
            {
                baseSalary = 8000;
            }

            double tax = baseSalary * 0.1;

            Console.WriteLine("Information about employee");
            Console.WriteLine("Surname:" + lastName);
            Console.WriteLine("Name:" + firstName);
            Console.WriteLine("Position:" + position);
            Console.WriteLine("Salary:" + baseSalary);
            Console.WriteLine("Tax:" + tax);
        }
    }
}