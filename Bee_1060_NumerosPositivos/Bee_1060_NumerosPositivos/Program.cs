using System;

namespace Bee_1060_NumerosPositivos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int cont = 0;

            for (int i = 0; i < 6; i++)
            {
                double n = double.Parse(Console.ReadLine());
                if ( n > 0 ) cont++;
            }
            Console.WriteLine(cont + " valores positivos");
        }
    }
}