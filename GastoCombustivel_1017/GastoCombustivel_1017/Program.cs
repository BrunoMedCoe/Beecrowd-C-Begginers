using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GastoCombustivel_1017
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double Tempo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double VelocidadeMedia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double ConsumoCombustivel = (Tempo * VelocidadeMedia) / 12;

            Console.WriteLine($"{ConsumoCombustivel.ToString("f3", CultureInfo.InvariantCulture)}");
        }
    }
}
