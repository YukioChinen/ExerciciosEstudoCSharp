using System;
using System.Globalization;

namespace ex3 {
    class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double areaTriRet = (a * c) / 2.0;
            double areaCirc = 3.14159 * Math.Pow(c, 2);
            double areaTrap = ((a + b) * c) / 2.0;
            double areaQuad = Math.Pow(b, 2);
            double areaRet = a * b;

            Console.WriteLine($"TRIANGULO: {areaTriRet.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCirc.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrap.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQuad.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRet.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}