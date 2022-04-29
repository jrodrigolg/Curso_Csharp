using System;
namespace ExPoo14
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();
            Console.WriteLine("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.Addvalue(x);
            }
            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}