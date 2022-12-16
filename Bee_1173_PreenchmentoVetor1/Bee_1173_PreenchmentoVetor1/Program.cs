using System;

namespace Bee_1173_PrenchimentoVetor1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] vetor = new int[10];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = n;

                n = n * 2;

                Console.WriteLine($"N[{i}] = {vetor[i]}");                
            }
        }
    }
}