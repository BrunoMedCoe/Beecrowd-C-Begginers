using System;

namespace Bee_1176_FibonacciVetor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int t, n;
            long a = 0, b = 1, c = 0;


            long[] fibonacci = new long[61];

            for (int i = 0; i < fibonacci.Length; i++)
            {
                fibonacci[i] = c;
                a = b;
                b = c;
                c = (a  + b);
            }

            t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine());

                Console.WriteLine($"Fib({n}) = {fibonacci[n]}");
            }
        }
    }
}