using ExPoo7.Entities;
using ExPoo7.Entities.Enums;
using System.Globalization;
namespace ExPoo7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name:");
            string nameClient = Console.ReadLine();
            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(nameClient, email, birthDate);
            Console.WriteLine("Enter order data:");
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.WriteLine("How many items to this order?");
            int qttItems = int.Parse(Console.ReadLine());

            Order order = new Order(status, client);
            for (int i = 0; i < qttItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, price);
                order.AddItem(new OrderItem(quantity, product));

            }
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order.ToString());

        }
    }
}