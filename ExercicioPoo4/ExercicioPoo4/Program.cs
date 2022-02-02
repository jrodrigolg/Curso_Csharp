using System;
using System.Collections.Generic;
namespace ExercicioPoo4 {
    public class Program {
        public static void Main(string[] args) {
            int i = 10;
            int x;
            Calculadora.Quad(i, out x);
            Calculadora.Triplo(ref i);
           

            Console.WriteLine(x);
            Console.WriteLine(i);
            List<string> list = new List<string>() { "teste", "maria" };
        }
    }
}