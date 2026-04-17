using System;
using System.Globalization;

namespace ex1 {
    class Program {
        static void Main(string[] args) {
            int alcool = 0, gasolina = 0, diesel = 0;
            while (true) {
                int n = int.Parse(Console.ReadLine());

                if (n == 4) {
                    Console.WriteLine("MUIO OBRIGADO");
                    Console.WriteLine($"Alcool: {alcool} ");
                    Console.WriteLine($"Gasolina: {gasolina}");
                    Console.WriteLine($"Diesel: {diesel}");
                    break;
                }
                if (n == 1) {
                    alcool++;
                }
                else if (n == 2) {
                    gasolina++;
                }
                else if (n == 3) {
                    diesel++;
                }
            }

        }
    }
}