using System;
namespace ExercicioEncapsulamento {
    class Program {
        static void Main(string[] args) {
            Conta conta;
           
            conta = criarConta();
            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine($"{conta}");
            Console.Write("\nEntre com um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            conta.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine("\nEntre com um valor para saque:");
            valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);
            Console.WriteLine(conta);
        }
        public static Conta criarConta() {
            int numero;
            string nome;
            double valor;
            Console.Write("Entre com o numero da conta: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial?(s/n)");
            if (Console.ReadLine() == "s") {
                Console.WriteLine("Entre o valor de depósito inicial:");
                valor = double.Parse(Console.ReadLine());
            }
            else {
                valor = 0;
            }
            Conta conta = new Conta(numero,nome, valor);
            return conta;
        }
    }
}