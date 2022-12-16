using System;

namespace Bee_1160_CrescimentoPopulacional
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int T, PA, PB, anos;
            double G1, G2;

            T = int.Parse(Console.ReadLine());

            for (int i = 1; i <= T; i++)
            {
                anos = 0;
                string[] entradas = Console.ReadLine().Split(' ');
                PA = int.Parse(entradas[0]);
                PB = int.Parse(entradas[1]);
                G1 = double.Parse(entradas[2]);
                G2 = double.Parse(entradas[3]);

                while (PA <= PB && anos <= 100)
                {
                    PA += (int)((PA * G1) / 1000);
                    PB += (int)((PB * G2) / 1000);
                    
                    anos++;                    
                }
                if (anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else
                {
                    Console.WriteLine($"{anos} anos.");
                }
            }
        }
    }
}
