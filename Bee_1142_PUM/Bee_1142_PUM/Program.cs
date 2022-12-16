using System;

namespace Bee_1142_PUM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= (4*N - 1); i += 4)
            {
                for (int j = i; j <= (i + 2); j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("PUM");
            }
        }
    }
}
