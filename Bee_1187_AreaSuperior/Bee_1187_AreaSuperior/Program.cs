using System;

namespace Bee_1187_AreaSuperior
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
                    matrix[i,j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 5; i < 7; i++)
            {
                soma += matrix[4, i];
            }

            for (int j = 4; j < 8; j++)
            {
                soma += matrix[3, j];
            }

            for (int k = 3; k < 9; k++)
            {
                soma += matrix[2, k];
            }

            for (int l = 2; l < 10; l++)
            {
                soma += matrix[1, l];
            }

            for (int m = 1; m < 11; m++)
            {
                soma += matrix[0, m];
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