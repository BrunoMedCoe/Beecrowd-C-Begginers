using System;
using System.Globalization;

namespace Bee_1178_PreenchimentoVtor3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double valorEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double[] vetor = new double[100];

            for (int i = 0, j = 0; i < vetor.Length; valorEntrada /= 2, i++, j++)
            {
                vetor[j] = valorEntrada;

                Console.WriteLine($"N[{i}] = {vetor[j].ToString("f4", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
