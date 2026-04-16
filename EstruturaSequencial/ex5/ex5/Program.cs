using System;
using System.Globalization;

namespace ex3 {
    class Program {
        static void Main(string[] args) {
            string[] vet1 = Console.ReadLine().Split(' ');
            int peca1 = int.Parse(vet1[0]);
            int numero1 = int.Parse(vet1[1]);
            double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int peca2 = int.Parse(vet2[0]);
            int numero2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valorTotal = (numero1 * valor1) + (numero2 * valor2);

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}