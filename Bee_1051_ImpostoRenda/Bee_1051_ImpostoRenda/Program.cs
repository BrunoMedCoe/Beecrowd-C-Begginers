using System;
using System.Globalization;

namespace Bee_1051_ImpostoRenda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double impostoRenda = 0.00;

            if (salario > 4500.00)
            {
                impostoRenda += ((salario - 4500.00) * 0.28);
                salario -= (salario - 4500.00);
            }
            if (salario > 3000.00)
            {
                impostoRenda += ((salario - 3000.00) * 0.18);
                salario -= (salario - 3000.00);
            }
            if (salario > 2000.00)
            {
                impostoRenda += ((salario - 2000.00) * 0.08);
            }
            if (impostoRenda == 0.00)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine($"R$ {impostoRenda.ToString("f2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
