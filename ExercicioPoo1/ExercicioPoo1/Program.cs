using System;
namespace ExercicioPoo1 {
    class Program {
        static void Main(string[] args) {
            Pessoa pessoa1;
            Pessoa pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade :");
            pessoa1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome:");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade :");
            pessoa2.Idade = int.Parse(Console.ReadLine());

        }
    }
}