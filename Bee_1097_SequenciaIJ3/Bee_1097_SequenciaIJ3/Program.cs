using System;

namespace Bee_1097_SequenciaIJ3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int k = 0;
                        
            for (int i = 1; i < 10; i += 2, k += 2)
            {
                for (int j = 7 + k; j >= 5 + k; j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }
        }
    }
}
