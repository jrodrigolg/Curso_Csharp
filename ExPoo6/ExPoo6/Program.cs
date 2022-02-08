using System;
using ExPoo6.Entities;
using ExPoo6.Entities.Enums;
using System.Globalization;
namespace ExPoo6 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter department's name:");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.WriteLine(  "Level (Junior/MidLevel/Senior:");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary:");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary,dept);

            Console.WriteLine("How many contracts to this worker?");
            int qttContracts= int.Parse(Console.ReadLine());
            for (int i = 0; i < qttContracts; i++) {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                Console.Write("Duration(hours):");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income(MM/YYYY):");
            string monthAndYear = Console.ReadLine();
            int year = int.Parse(monthAndYear.Substring(3));
            int month = int.Parse(monthAndYear.Substring(0,2));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department : "+worker.Department.Name);
            Console.WriteLine("Income for "+ monthAndYear +": "+worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}