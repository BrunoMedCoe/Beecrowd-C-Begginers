using System;

namespace Bee_1175_TrocaVetor1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] vetor = new int[20];

            int count = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(vetor);

            foreach (int n in vetor)
            {
                Console.WriteLine($"N[{count}] = {n}");

                count++;
            }
        }
    }
}