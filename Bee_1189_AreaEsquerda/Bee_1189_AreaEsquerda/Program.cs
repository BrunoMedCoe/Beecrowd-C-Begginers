using System;

namespace Bee_1189_AreaEsquerda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char O = char.Parse(Console.ReadLine());

            double[,] matrix = new double[12, 12];
            double soma = 0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 5; i < 7; i++)
            {
                soma += matrix[i,4];
            }

            for (int j = 4; j < 8; j++)
            {
                soma += matrix[j,3];
            }

            for (int k = 3; k < 9; k++)
            {
                soma += matrix[k,2];
            }

            for (int l = 2; l < 10; l++)
            {
                soma += matrix[l,1];
            }

            for (int m = 1; m < 11; m++)
            {
                soma += matrix[m,0];
            }

            if (O == 'S')
            {
                Console.WriteLine($"{soma:f1}");
            }
            else if (O == 'M')
            {
                Console.WriteLine($"{soma / 30.0f:f1}");
            }
        }
    }
}