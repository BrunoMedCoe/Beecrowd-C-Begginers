using System;
using System.Globalization;

namespace Bee_1116_DividindoXporY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x, y;
            double resultado = 0;

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    resultado = (float)x / y;

                    Console.WriteLine(resultado.ToString("f1", CultureInfo.InvariantCulture));
                }
            }                        
        }
    }
}