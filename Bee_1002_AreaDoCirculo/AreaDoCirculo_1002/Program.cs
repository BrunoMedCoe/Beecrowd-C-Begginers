using System.Globalization;

namespace AreaDoCirculo_1002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double area, raio;

            raio = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

            area = (3.14159 * raio * raio);

            Console.WriteLine($"A={area.ToString("f4", CultureInfo.InvariantCulture)}");
        }
    }
}