using System;
using System.Globalization;

namespace Bee_1174_SelecaoVetor1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] vetor = new double[100];

            for (int i = 0; i < 100; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < 100; i++)
            {
                if (vetor[i] <= 10)
                {
                    Console.WriteLine($"A[{i}] = {vetor[i].ToString("f1", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}