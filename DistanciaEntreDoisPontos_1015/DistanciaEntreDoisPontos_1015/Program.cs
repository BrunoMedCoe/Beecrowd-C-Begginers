using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DistanciaEntreDoisPontos_1015
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] x1y1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(x1y1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(x1y1[1], CultureInfo.InvariantCulture);

            string[] x2y2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(x2y2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(x2y2[1], CultureInfo.InvariantCulture);

            double Distancia = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));

            Console.WriteLine(Distancia.ToString("f4", CultureInfo.InvariantCulture));
        }
    }
}
