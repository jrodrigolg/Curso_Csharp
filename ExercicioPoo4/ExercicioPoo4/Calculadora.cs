using System;


namespace ExercicioPoo4 {
    internal class Calculadora {
        public static void Triplo(ref int x) {
            x *= 3;
        }
        public static void Quad(int x, out int y) {
            y = x * 4;
        }
    }
}
