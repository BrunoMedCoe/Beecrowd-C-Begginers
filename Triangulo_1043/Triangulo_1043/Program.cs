using System;
using System.Globalization;

namespace Triangulo_1043
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] Pontos = Console.ReadLine().Split(' ');
            double a = double.Parse(Pontos[0], CultureInfo.InvariantCulture);
            double b = double.Parse(Pontos[1], CultureInfo.InvariantCulture);
            double c = double.Parse(Pontos[2], CultureInfo.InvariantCulture);

            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                double Perimetro = (a + b + c);
                Console.WriteLine($"Perimetro = {Perimetro.ToString("f1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                double Area = ((a + b) * c) / 2;
                Console.WriteLine($"Area = {Area.ToString("f1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
