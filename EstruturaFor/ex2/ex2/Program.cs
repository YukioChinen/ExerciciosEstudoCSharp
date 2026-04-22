using System;
using System.Globalization;

namespace ex2 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int countIn = 0, countOut = 0;

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20) {
                    countIn++;
                } else {
                    countOut++;
                }

            }

            Console.WriteLine($"{countIn} in");
            Console.WriteLine($"{countOut} out");


        }
    }
}