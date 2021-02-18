using EmployeeLambda.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace EmployeeLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter full file path: ");

            using (StreamReader sr = File.OpenText(Console.ReadLine()))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(",");
                    employees.Add(new Employee (fields[0], fields[1], double.Parse(fields[2], CultureInfo.InvariantCulture)));
                }
            }

            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Email of people whose salary is more than " + salary.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("");

            employees.Where(x => x.Salary > salary).OrderBy(x => x.Name).ToList().ForEach(x => Console.WriteLine(x.Email));

            Console.Write("Sum of salary of people whose name starts with 'M': " + employees.Where(x => x.Name.StartsWith("M")).Select(x => x.Salary).DefaultIfEmpty(0.0).Sum().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
