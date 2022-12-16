using System;

namespace Bee_1067_NumerosImpares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int impar = 0;
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numero ; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}