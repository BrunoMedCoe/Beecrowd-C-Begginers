using System;

public class Program
{
    public static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int number = 0;

        if (x == y)
        {
            number = 0;
        }
        else if (x < y)
        {
            for (x = x+1; x < y; x++)
            {
                if (x % 2 == 1 || x % 2 == -1)
                {
                    number += x;
                }
            }
        }
        else if (x > y)
        {
            for (y = y+1; y < x; y++)
            {
                if (y % 2 ==1 || y % 2 == -1)
                {
                    number += y;
                }
            }
        }
        Console.WriteLine(number);
    }
}
