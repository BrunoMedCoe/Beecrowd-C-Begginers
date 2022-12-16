using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Media1_1005
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media1;

            media1 = (nota1 * 3.5 + nota2 * 7.5) / 11;

            Console.WriteLine($"MEDIA = {media1.ToString("f5", CultureInfo.InvariantCulture)}");
        }
    }
}