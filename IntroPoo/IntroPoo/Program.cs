using System;
using System.Globalization;
namespace IntroPoo {
    class Program {
        static void Main(string[] args) {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo X:");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture) ;
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();
            Console.WriteLine($"area do triangulo X = {areaX:F2}");
            Console.WriteLine($"area do triangulo Y = {areaY:F2}");

        }
    }

}