using System;
using System.Globalization;

namespace ex5 {
    class Program {
        static void Main(string[] args) {
            int number = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= number; i++) {
                fatorial *= i;
            }
            Console.WriteLine(fatorial);
        }
    }
}