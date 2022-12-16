using System;

namespace Bee_1113_CrescenteDecrescente
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x, y;

            do
            {
                string[] entrada = Console.ReadLine().Split(' ');
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);

                if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                else if (y > x)
                {
                    Console.WriteLine("Crescente");
                }
            }
            while (x != y);
        }
    }
}
