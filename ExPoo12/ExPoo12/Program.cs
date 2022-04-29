using System;
using ExPoo12.Entities.Exceptions;
using ExPoo12.Entities;
using System.Globalization;
namespace ExPoo12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string name = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double initialBalance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());
            Console.Write("Enter amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine());
            account = new Account(number, name, initialBalance, withdrawLimit);

            try
            {
                account.Withdraw(withdraw);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("teste"); }
            Console.WriteLine("teste");
            
        }
    }
}