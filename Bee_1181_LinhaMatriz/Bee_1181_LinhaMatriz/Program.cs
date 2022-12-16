using System;

namespace Bee_1181_LinhaMatriz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int L = int.Parse(Console.ReadLine());
            float[,] matrix = new float[12,12];
            float soma = 0;
            char T = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matrix[i,j] = float.Parse(Console.ReadLine());
                }
            }

            for (int j = 0; j < 12; j++)
            {
                soma += matrix[L, j];
            }
            if (T == 'S')
            {
                Console.WriteLine($"{0:F1}", soma);
            }
            else if (T == 'M')
            {
                Console.WriteLine($"{soma / 12.0f:f1}");
            }
        }
    }
}