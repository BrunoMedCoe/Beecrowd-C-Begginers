using System;

namespace Bee_1151_Fibonacci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write($"{c} ");
                    c = (a + b);
                    a = c;
                }
                else if (i ==  2)
                {
                    Console.Write($"{c} ");
                }
                else if (i % 2 == 0)
                {
                    Console.Write($"{c} ");
                    c = (a + b);
                    b = c;
                }                
            }

            Console.Write($"{c}\n");
        }
    }
}