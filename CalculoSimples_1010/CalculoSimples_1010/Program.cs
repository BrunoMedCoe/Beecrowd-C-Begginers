using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculoSimples_1010
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] Compra1 = Console.ReadLine().Split(' ');
            int CodigoPeca1 = int.Parse(Compra1[0]);
            int QuantidadePeca1 = int.Parse(Compra1[1]);
            double NumeroPeca1 = double.Parse(Compra1[2], CultureInfo.InvariantCulture);

            string[] Compra2 = Console.ReadLine().Split(' ');
            int CodigoPeca2 = int.Parse(Compra2[0]);
            int QuantidadePeca2 = int.Parse(Compra2[1]);
            double NumeroPeca2 = double.Parse(Compra2[2], CultureInfo.InvariantCulture);

            double Total = (QuantidadePeca1 * NumeroPeca1) + (QuantidadePeca2 * NumeroPeca2);

            Console.WriteLine($"VALOR A PAGAR = R$ {Total.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}
