using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Intervalo_1037
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (N >= 0 && N <= 25.0000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (N >= 25.00001 && N <= 50.0000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (N >= 50.00001 && N <= 75.0000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (N >= 75.00001 && N <= 100.0000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}