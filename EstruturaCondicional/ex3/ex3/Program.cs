using System;

namespace ex2 {
    class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            int sobra1 = A % B;
            int sobra2 = B % A;

            if (sobra1 ==0 || sobra2 == 0) {
                Console.WriteLine("Sao Multiplos");
            } else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}