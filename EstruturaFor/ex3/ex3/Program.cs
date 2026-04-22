using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace ex3 {
    class Program {
        static void Main(string[] args) {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double mediaPonderada = (n1*2 + n2*3 + n3*5) / 10;
                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}