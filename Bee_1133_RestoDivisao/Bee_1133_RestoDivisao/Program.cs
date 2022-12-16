using System;

namespace Bee_1133_RestoDivisao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                for (int i = y + 1; i < x; i++)
                {
                    if (i % 5 == 2 || i % 5 == 3)
                    {
                        Console.WriteLine(i);
                    }
                }
            } else
            {
                for (int j = x + 1; j < y; j++)
                {
                    if (j % 5 == 2 || j % 5 == 3)
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
    }
}
