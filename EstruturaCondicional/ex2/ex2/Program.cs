using System;

namespace ex2 {
    class Program {
        static void Main(string[] args) {
            int numero = int.Parse(Console.ReadLine());

            int resto = numero % 2;

            if (resto == 0) {
                Console.WriteLine("PAR");
            } else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}