using System;

namespace Bee_1182_ColunaMatriz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int C = int.Parse(Console.ReadLine());
            char T = char.Parse(Console.ReadLine());
            float[,] matrix= new float[12,12];
            float soma = 0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matrix[i,j] = float.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 12; i++)
            {
                soma += matrix[i, C];
            }
            if (T == 'S')
            {
                Console.WriteLine($"{soma:f1}");
            }
            else if (T == 'M')
            {
                Console.WriteLine($"{soma/12.0f:f1}");
            }
        }
    }
}