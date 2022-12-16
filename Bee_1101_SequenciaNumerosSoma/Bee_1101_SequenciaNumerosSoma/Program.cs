using System;

namespace Bee_1101_SequenciaNumerosSoma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int soma = 0;

            string[] intervalo = Console.ReadLine().Split(' ');
            int m = int.Parse(intervalo[0]);
            int n = int.Parse(intervalo[1]);

            while (m > 0 && n > 0)
            {
                soma = 0;

                if (m > 0 && n > 0)
                {
                    if (m > n)
                    {
                        for (int i = n; i <= m; i++)
                        {
                            soma += i;
                            Console.Write($"{i} ");
                        }
                        Console.WriteLine($"Sum={soma}");
                    }
                    else
                    {
                        for (int i = m; i <= n; i++)
                        {
                            soma = soma + i;
                            Console.Write($"{i} ");
                        }
                        Console.WriteLine($"Sum={soma}");
                    }

                    string[] intervalo2 = Console.ReadLine().Split(' ');
                    m = int.Parse(intervalo2[0]);
                    n = int.Parse(intervalo2[1]);
                }
            }
        }
    }
}
