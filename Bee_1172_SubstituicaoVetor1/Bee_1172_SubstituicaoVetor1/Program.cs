using System;

namespace Bee_1172_SubstituicaoVetor1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] <= 0)
                {
                    vetor[i] = 1;
                }

                Console.WriteLine($"X[{i}] = {vetor[i]}");
            }
        }
    }
}