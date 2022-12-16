using System;

namespace Bee_1156_SequenciaS2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float s = 1;
            float i, j;

            for (i = 3, j = 2; i <= 39; i += 2, j *= 2)
            {
                s += (i/j);
            }

            Console.WriteLine($"{s.ToString("f2")}");
        }
    }
}
