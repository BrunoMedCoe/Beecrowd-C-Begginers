using System;

namespace Bee_1074_ParImpar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, x;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("NULL");
                } 
                
                if (x > 0 && x % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                } else if (x < 0 && x % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }

                if (x > 0 && x % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                } else if (x < 0 && x % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }        
        }
    }
}