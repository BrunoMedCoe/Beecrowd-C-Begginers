using System;

namespace Bee_1180_MenorPosicao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int menorValor = 0;
            int posicaoMenor = 0;

            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n]; ;

            string[] linha = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vetor[i] = int.Parse(linha[i]);

                if (i == 0)
                {
                    menorValor = vetor[i];
                    posicaoMenor = i;
                }
                else if (vetor[i] < menorValor)
                {
                    menorValor= vetor[i];
                    posicaoMenor = i;
                }
            }

            Console.WriteLine($"Menor valor: {menorValor}");

            Console.WriteLine($"Posicao: {posicaoMenor}");
        }
    }
}
