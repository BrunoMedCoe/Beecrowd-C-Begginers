using System;
using System.Linq;

namespace Bee_1080_MaiorPosicao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number;
            int[] value = new int[100];

            for (int i = 0; i < 100; i++)
            {
                number = int.Parse(Console.ReadLine());
                value[i] = number;
            }
            int highValue = value.Max();
            Console.WriteLine(highValue);

            int index = Array.IndexOf(value, highValue);
            Console.WriteLine(index+1);
        }
    }
}