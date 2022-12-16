using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Area_1012
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] Area = Console.ReadLine().Split(' ');

            double PontoA = double.Parse(Area[0], CultureInfo.InvariantCulture);
            double PontoB = double.Parse(Area[1], CultureInfo.InvariantCulture);
            double PontoC = double.Parse(Area[2], CultureInfo.InvariantCulture);

            double AreaTriangulo = (PontoA * PontoC) / 2;

            double AreaCirculo = 3.14159 * (PontoC * PontoC);

            double AreaTrapezio = ((PontoA + PontoB) * PontoC) / 2;

            double AreaQuadrado = PontoB * PontoB;

            double AreaRetangulo = PontoA * PontoB;

            Console.WriteLine($"TRIANGULO: {AreaTriangulo.ToString("f3", CultureInfo.InvariantCulture)}\n" +
                $"CIRCULO: {AreaCirculo.ToString("f3", CultureInfo.InvariantCulture)}\n" +
                $"TRAPEZIO: {AreaTrapezio.ToString("f3", CultureInfo.InvariantCulture)}\n" +
                $"QUADRADO: {AreaQuadrado.ToString("f3", CultureInfo.InvariantCulture)}\n" +
                $"RETANGULO: {AreaRetangulo.ToString("f3", CultureInfo.InvariantCulture)}");
        }
    }
}
