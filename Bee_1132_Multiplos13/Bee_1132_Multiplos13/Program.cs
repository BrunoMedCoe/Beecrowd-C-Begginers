using System;

namespace Bee_1132_Multiplos13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int soma = 0;
            int aux = 0;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                aux = x;
                x = y;
                y = aux;
            }

            for (int i = x; i <= y; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}