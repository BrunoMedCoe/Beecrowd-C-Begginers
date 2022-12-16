using System;

namespace Bee_1099_SomaImparesConseutivosII
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x, y, N;
            int quantImpar = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                quantImpar = 0;
                string[] linha1 = Console.ReadLine().Split(' ');

                x = int.Parse(linha1[0]);
                y = int.Parse(linha1[1]);
                
                if (x > y)
                {
                    for (int j = y + 1; j < x; j++)
                    {
                        if (j % 2 != 0)
                        {
                            quantImpar += j;
                        }
                    }

                    Console.WriteLine(quantImpar);
                }
                else
                {
                    for (int j = x + 1; j < y; j++)
                    {
                        if (j % 2 != 0)
                        {
                            quantImpar += j;
                        }
                    }

                    Console.WriteLine(quantImpar);
                }
            }
        }
    }
}
