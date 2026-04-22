using System;
using System.Globalization;

namespace ex4 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            string[] vet;
            double n1, n2, result;

            for (int i = 0; i < n; i++) {
                vet = Console.ReadLine().Split(' ');
                n1 = double.Parse(vet[0]);
                n2 = double.Parse(vet[1]);

                if (n2 != 0) {
                    result = n1 / n2;
                    Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
                }
                else {
                    Console.WriteLine("divisao impossivel");
                }


            }
        }
    }
}