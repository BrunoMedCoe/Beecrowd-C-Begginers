using System;
using System.Globalization;

namespace Bee_1046_PositivosMedia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double media = 0;
            int positivo = 0;

            for (int i = 0; i < 6; i++)
            {
                double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (numero > 0)
                {
                    positivo++;
                    media = media + numero;
                }
            }
            media = (media / positivo);

            Console.WriteLine($"{positivo} valores positivos");
            Console.WriteLine(media.ToString("f1"), CultureInfo.InvariantCulture);
        }
    }
}