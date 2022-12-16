using System;

namespace Bee_1073_QuadradoPares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int n = 2;

            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}^{n} = {Math.Pow(i,2)}");
                }
            }
        }
    }
}
