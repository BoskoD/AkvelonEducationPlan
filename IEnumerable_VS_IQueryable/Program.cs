using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerable_VS_IQueryable
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EmployeeContext("Server=(localdb)\\MSSQLLocalDB;Database=Employees;Trusted_Connection=True;MultipleActiveResultSets=true");

            // In-memory
            IEnumerable<Employee> enumEmployees = context.Employees
                .Where(e => e.Id > 1);
            var topEnumEmployees = enumEmployees.Take(2);

            foreach (var emp in topEnumEmployees)
            {
                Console.WriteLine($"Name - {emp.FirstName} {emp.LastName} :: {emp.BirthDate}");
            }

            Console.WriteLine();

            // Out-memory
            IQueryable<Employee> quearyableEmployees = context.Employees
                .Where(e => e.Id > 1);
            var topQueryEmployees = quearyableEmployees.Take(2);

            foreach (var emp in topQueryEmployees)
            {
                Console.WriteLine($"Name - {emp.FirstName} {emp.LastName} :: {emp.BirthDate}");
            }

        }
    }
}

