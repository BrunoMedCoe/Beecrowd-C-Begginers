using System;

namespace Bee_1159_SomaParesConsecutivos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                int soma = 0;

                for (int i = x, j = 1; j <= 5; i++)
                {
                    if (i % 2 == 0)
                    {
                        soma += i;
                        j += 1;
                    }
                }
                Console.WriteLine(soma);
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
