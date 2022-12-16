using System;

namespace Bee_1095_SequenciaIJ1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, j;

            for (i = 1, j = 60; j >= 0; i = i + 3, j = j - 5)
            {
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}
