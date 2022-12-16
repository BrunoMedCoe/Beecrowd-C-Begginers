using System;

namespace Bee_1164_NumeroPerfeito
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int valor = 0;
                int total = 0;
                valor = int.Parse(Console.ReadLine());

                for (int j = 1; j < valor; j++)
                {
                    if (valor % j == 0)
                    {
                        total += j;
                    }
                }
                if (valor == total)
                {
                    Console.WriteLine($"{valor} eh perfeito");
                }
                else
                {
                    Console.WriteLine($"{valor} nao eh perfeito");
                }
            }
        }
    }
}
