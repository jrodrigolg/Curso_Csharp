using System;//namespace padrao que contem funçoes basicas
using System.Globalization;
namespace Primeiro {
    class Program {
        static void Main(string[] args) {
            int codPeca1, numPecas1, codPeca2, numPecas2;
            double valorPeca1, valorPeca2, total;
            string[] dados = Console.ReadLine().Split(' ');
            codPeca1 = int.Parse(dados[0]);
            numPecas1 = int.Parse(dados[1]);
            valorPeca1 = double.Parse(dados[2],CultureInfo.InvariantCulture);
            
            dados = Console.ReadLine().Split(' ');
            codPeca2 = int.Parse(dados[0]);
            numPecas2 = int.Parse(dados[1]);
            valorPeca2 = double.Parse(dados[2], CultureInfo.InvariantCulture);
            total = numPecas1 * valorPeca1 + numPecas2 * valorPeca2;
            Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
        }
    }
}