using System;
using System.Globalization;

namespace Bee_1118_VariasNotasValidacao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double n1, n2, media;
            double calculo = 1;

            do
            {
                do
                {
                    n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (n1 < 0.0 || n1 > 10.0)
                    {
                        Console.WriteLine("nota invalida");
                    }
                }
                while (n1 < 0.0 || n1 > 10.0);

                do
                {
                    n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (n2 < 0.0 || n2 > 10.0)
                    {
                        Console.WriteLine("nota invalida");
                    }
                }
                while (n2 < 0.0 || n2 > 10.0);

                media = (n1 + n2) / 2;

                Console.WriteLine($"media = {media.ToString("f2", CultureInfo.InvariantCulture)}");

                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    calculo = int.Parse(Console.ReadLine());
                }
                while (calculo != 1 && calculo != 2);
            }
            while (calculo == 1);        
        }
    }
}