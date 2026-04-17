using System;
using System.Globalization;

namespace ex2 {
    class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int qtd = int.Parse(vet[1]);

            if (codigo == 1) {
                Console.WriteLine("Total: R$ " + (qtd * 4.00).ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 2) {
                Console.WriteLine("Total: R$ " + (qtd * 4.50).ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 3) {
                Console.WriteLine("Total: R$ " + (qtd * 5.00).ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 4) {
                Console.WriteLine("Total: R$ " + (qtd * 2.00).ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 5) {
                Console.WriteLine("Total: R$ " + (qtd * 1.50).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}