using System;

namespace Bee_1153_FatorialSimples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int fatorial = 1;
            int x = 1;

            int n = int.Parse(Console.ReadLine());

            while (x <= n)
            {
                fatorial = fatorial * x;
                x++;
            }

            Console.WriteLine(fatorial);
        }
    }
}