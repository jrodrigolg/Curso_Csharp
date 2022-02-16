using System;
using ExPoo8.Entities;
namespace ExPoo8
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees:");
            int qttEmployees = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < qttEmployees; i++)
            {
                Console.Write("Outsorced(y/n)");
                char x = char.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Hours");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value Per Hours");
                double valuePerHour = double.Parse(Console.ReadLine());
                if (x == 'y')
                {
                    Console.WriteLine("Additional charge:");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employees.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));

                    }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
