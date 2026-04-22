using System;
using System.Globalization;

namespace ex7 {
    class Program {
        static void Main(string[] args) {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++) {
                int quadrado = i * i;
                int cubo = i * i * i;
                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
        }
    }
}