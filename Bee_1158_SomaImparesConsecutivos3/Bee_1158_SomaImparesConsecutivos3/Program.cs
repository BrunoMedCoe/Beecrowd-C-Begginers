using System;

namespace Bee_1158_SomaImparesConsecutivos3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, x, y;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int soma = 0;

                string[] entrada = Console.ReadLine().Split(' ');
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);

                for (int j = x, total = 0; total < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                        total += 1;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}