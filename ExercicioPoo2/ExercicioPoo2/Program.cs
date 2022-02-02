using System;
using System.Globalization;
namespace ExercicioPoo2 {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("tv", 500.00, 10);
            p.Nome = "geladeira";
            Console.WriteLine(p.ToString());
            /*
            Console.WriteLine("Entre com os dados do Produto");
            Console.Write("Nome :");
            string Nome = Console.ReadLine();
            Console.Write("Preço :");
            double Valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write(  "Quantidade no estoque :");
            int Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto p = new Produto(Nome, Valor, Quantidade);

            Console.WriteLine("Dados do produto : "+p);
            Console.WriteLine();
            
            Console.WriteLine("Digite a quantidade de produtos para ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            
            Console.WriteLine() ;
            Console.WriteLine("Dados atualizados : " + p);
            Console.WriteLine();
            
            Console.WriteLine("Digite a quantidade para ser removido: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados : " + p);
            */

        }
    }
}