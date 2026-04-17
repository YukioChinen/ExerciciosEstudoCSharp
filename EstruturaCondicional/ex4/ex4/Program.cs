using System;
using System.Runtime.ConstrainedExecution;

namespace ex2 {
    class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');
            int hora1 = int.Parse(vet[0]);
            int hora2 = int.Parse(vet[1]);
            int final = 0;

            if (hora2 > hora1) {
                final = hora2 - hora1;
            } else {
                final = 24 - (hora1 - hora2);
            }
            Console.WriteLine($"O JOGO DUROU {final} HORA(S)");
        }
    }
}