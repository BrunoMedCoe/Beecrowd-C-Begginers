using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Media2_1006
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double notaA = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double notaB = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double notaC = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media2;

            media2 = (notaA * 2 + notaB * 3 + notaC * 5) / 10;

            Console.WriteLine($"MEDIA = {media2.ToString("f1", CultureInfo.InvariantCulture)}");
        }
    }
}