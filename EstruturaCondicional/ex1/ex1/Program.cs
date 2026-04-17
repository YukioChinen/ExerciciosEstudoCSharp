using System;
using System.Globalization;

namespace ex3 {
    class Program {
        static void Main(string[] args) {
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0) {
                Console.WriteLine("NEGATIVO");
            } else {
                Console.WriteLine("NAO NEGATIVO");
            }
            
        }
    }
}