using System;

namespace Bee_1146_SequenciasCrescentes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N;
            
            do
            {
                N = int.Parse(Console.ReadLine());

                for (int i = 1; i <= N; i++)
                {
                    if (i < N)
                    {
                        Console.Write($"{i} ");
                    }
                    else
                    {
                        Console.Write($"{i}\n");
                    }
                }
            } while (N != 0);
        }
    }
}
