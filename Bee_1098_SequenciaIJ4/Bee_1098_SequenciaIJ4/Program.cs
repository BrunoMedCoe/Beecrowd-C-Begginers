using System;
using System.Globalization;

namespace Bee_1098_SequenciaIJ4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (double i = 0; i <= 2; i += 0.2)
            {
                for (double j = 1; j <= 3; j++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine($"I={i:F0} J={j:F0}");
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine($"I={i:F0} J={(j + i):F0}");
                    }
                    else if (i > 1.9)
                    {
                        Console.WriteLine($"I={i:F0} J={(j + i):F0}");
                    }
                    else
                    {
                        Console.WriteLine($"I={i:F1} J={(j + i):F1}");
                    }
                }
            }
        }
    }
}


