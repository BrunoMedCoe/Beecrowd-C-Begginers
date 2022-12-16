using System;

namespace Bee_1165_NumeroPrimo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            int x = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                x = int.Parse((Console.ReadLine()));
                count = 0;

                for (int j = 1; j < x; j++)
                {
                    if (x % j == 0)
                    {
                        count += j;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine($"{x} eh primo");
                }
                else
                {
                    Console.WriteLine($"{x} nao eh primo");
                }
            }
        }
    }
}
