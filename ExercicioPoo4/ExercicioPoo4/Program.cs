using System;
using System.Collections.Generic;
using System.Globalization;
namespace ExercicioPoo4 {
    public class Program {
        public static void Main(string[] args) {
            int id;
            string name;
            double salary;
            List<Employee> employee = new List<Employee>();
            Console.WriteLine("How many employees will e registered?");
            int quant_emp = int.Parse(Console.ReadLine());

            for (int i = 0; i < quant_emp; i++) {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine());
                employee.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("Enter the employee i that will have salary increase :");
            int searchId = int.Parse(Console.ReadLine());
            

            int indexEmp = employee.FindIndex(x => x.id == searchId);
            if (indexEmp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee[indexEmp].IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in employee) {
                Console.WriteLine(obj);
            }
        }
    }
}