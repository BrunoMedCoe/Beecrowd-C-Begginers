using System;

namespace Bee_1070_SeisNumerosImpares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            int numero = int.Parse(Console.ReadLine());

            while (i < 6)
            {
                if (numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                    i++;
                }
                numero++;
            }
        }
    }
}