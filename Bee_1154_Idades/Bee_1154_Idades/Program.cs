using System;

namespace Bee_1154_Idades
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int cont = 0;
            int x = 0;
            int idade;

            do
            {
                idade = int.Parse(Console.ReadLine());

                if (idade > 0)
                {
                    x += idade;
                    cont++;
                }
            }
            while (idade > 0);

            float media = (float)x / cont;

            Console.WriteLine($"{media.ToString("f2")}");
        }
    }
}