using System;

namespace Bee_1155_SequenciaS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double s = 1;

            for (int i = 2; i <= 100; i++)
            {
                s += 1.00 / i;
            }

            Console.WriteLine($"{s.ToString("f2")}");
        }
    }
}