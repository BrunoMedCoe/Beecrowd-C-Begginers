using System;

namespace Bee_1059_NumeroPares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;

            for (i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}