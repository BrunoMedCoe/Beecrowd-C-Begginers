using System;

namespace Bee_1177_PreenchimentoVetor2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            int[] vetor = new int[1000];

            int posicao = 0;

            while (posicao < 999)
            {
                for (int i = 0; i < t; i++)
                {
                    if (posicao > 999)                    
                        break;

                        vetor[posicao] = i;

                        posicao++;                    
                }                
            }
            for (int j = 0; j < vetor.Length; j++)
            {
                Console.WriteLine($"N[{j}] = {vetor[j]}");
            }
        }
    }
}