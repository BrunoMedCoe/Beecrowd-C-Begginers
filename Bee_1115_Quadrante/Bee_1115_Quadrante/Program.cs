using System;

namespace Bee_1115_Quadrante
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float x, y;
            float num = 0.0f;

            do
            {
                string[] entrada = Console.ReadLine().Split(' ');
                x = float.Parse(entrada[0]);
                y = float.Parse(entrada[1]);

                if (x > num && y > num)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < num && y > num)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < num && y < num)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > num && y < num)
                {
                    Console.WriteLine("quarto");
                }
            }
            while (x != 0 && y != 0);
        }
    }
}
