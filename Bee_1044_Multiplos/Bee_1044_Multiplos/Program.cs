using System;
using System.Globalization;

namespace Bee_1044_Multiplos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] Valores = Console.ReadLine().Split(' ');
            int A = int.Parse(Valores[0]);
            int B = int.Parse(Valores[1]); 
            int Multiplo;

            if (A < B)
            {
                Multiplo = B % A;
            }
            else
            {
                Multiplo = A % B;
            }

            if (Multiplo == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
