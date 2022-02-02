using System;
namespace EXercicioPoo3 {
    class Program {
        static void Main(string[] args) {
            double[] vect = new double[10];
            vect[0] = 2;
            vect[1] = 1;
            vect[2] = 2;
            vect[3] = 3;
            vect[4] = 4;
            vect[5] = 5;
            vect[6] = 6;
            vect[7] = 7;
            vect[8] = 8;
            vect[9] = 9;
            foreach (var item in vect) {
                Console.WriteLine(item);

            }

        }
    }
}
