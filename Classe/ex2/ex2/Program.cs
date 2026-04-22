using System;
using System.Globalization;

namespace ex2 {
    class Program {
        static void Main(string[] args) {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (func1.Salario + func2.Salario) / 2;

            Console.Write($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}