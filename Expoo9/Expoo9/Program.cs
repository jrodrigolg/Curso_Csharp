using System;
using System.Globalization;
using Expoo9.Entities;
namespace Expoo9
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the number of products:");
            
            int qttProducts = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();
            for (int i = 0; i < qttProducts; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char x = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine());
                
                if (x == 'i')
                {
                    Console.Write("Customs fee:");
                    double customFee = double.Parse(Console.ReadLine());
                    
                    products.Add(new ImportedProduct(name, price, customFee));

                }
                else if (x == 'u')
                {
                    Console.Write("Manufacture date:");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else {
                    
                    products.Add(new Product(name, price));
                }
            }
            foreach (Product pdct in products)
            {
                Console.WriteLine(pdct.PriceTag());
            }
        }
    }
}