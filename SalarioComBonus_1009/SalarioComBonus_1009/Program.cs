using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SalarioComBonus_1009
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string Nome = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double VendasMes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 0.15; //15%

            double TotalMes = salarioFixo + VendasMes;

            Console.WriteLine($"TOTAL = R$ {TotalMes.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}
