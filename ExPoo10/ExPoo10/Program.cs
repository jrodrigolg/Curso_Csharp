using ExPoo10.Entities;
namespace ExPoo10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of tax payers:");
            int numTaxPayers = int.Parse(Console.ReadLine());
            List<TaxPayer> taxPayers = new();
            for (int i = 0; i < numTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual or company (i/c)?");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Anual income:");
                double anualIncome = double.Parse(Console.ReadLine());
                
                
                if (c == 'i')
                {
                    Console.Write("Health expenditures:");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees:");
                   int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            double total = 0;
            foreach (TaxPayer item in taxPayers)
            {
                Console.WriteLine(item.ToString());
                total += item.Tax();
            }
            Console.WriteLine($"TOTAL TAXES: $ {total:F2}" );
        }
    }
}