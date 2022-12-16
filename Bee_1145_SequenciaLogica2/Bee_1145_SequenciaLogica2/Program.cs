using System;

namespace Bee_1145_SequenciaLogica2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] linhaEntrada = Console.ReadLine().Split(' ');
            int x = int.Parse(linhaEntrada[0]);
            int y = int.Parse(linhaEntrada[1]);

            int count = 1;

            for (int i = 1; i <= y; i++)
            {
                Console.Write(i);

                if (x == count)
                {
                    Console.WriteLine();
                    count = 1;
                }
                else if (count < x)
                {
                    Console.Write(" ");
                    count++;
                }
            }
        }
    }
}