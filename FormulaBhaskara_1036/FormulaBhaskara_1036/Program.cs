﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FormulaBhaskara_1036
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double delta = (Math.Pow(B, 2)) - (4 * A * C);

            double R1 = (-B + (Math.Sqrt(delta))) / (2 * A);
            double R2 = (-B - (Math.Sqrt(delta))) / (2 * A);

            if (A != 0 && delta > 0)
            {
                Console.WriteLine($"R1 = {R1.ToString("f5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {R2.ToString("f5", CultureInfo.InvariantCulture)}");
            } else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
