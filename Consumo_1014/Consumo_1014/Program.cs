using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Consumo_1014
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumo = X/ Y;

            Console.WriteLine($"{consumo.ToString("f3", CultureInfo.InvariantCulture)} km/l");
        }
    }
}
