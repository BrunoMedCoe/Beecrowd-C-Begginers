using System;
using System.Globalization;

namespace Bee_1048_AumentoSalario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double novoSalario, reajusteSalario;
            
            if ((salario >= 0) && (salario <= 400.00)) 
            {
                novoSalario = ((salario * 0.15) + salario);
                reajusteSalario = (salario * 0.15);
                Console.WriteLine($"Novo salario: {novoSalario.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajusteSalario.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: 15 %");
            }
            else if ((salario >= 400.01) && (salario <= 800.00))
            {
                novoSalario = ((salario * 0.12) + salario);
                reajusteSalario = (salario * 0.12);
                Console.WriteLine($"Novo salario: {novoSalario.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajusteSalario.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: 12 %");
            }
            else if ((salario >= 800.01) && (salario <= 1200.00))
            {
                novoSalario = ((salario * 0.10) + salario);
                reajusteSalario = (salario * 0.10);
                Console.WriteLine($"Novo salario: {novoSalario.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajusteSalario.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: 10 %");
            }
            else if ((salario >= 1200.01) && (salario <= 2000.00))
            {
                novoSalario = ((salario * 0.07) + salario);
                reajusteSalario = (salario * 0.07);
                Console.WriteLine($"Novo salario: {novoSalario.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajusteSalario.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: 7 %");
            }
            else if (salario > 2000.00)
            {
                novoSalario = ((salario * 0.04) + salario);
                reajusteSalario = (salario * 0.04);
                Console.WriteLine($"Novo salario: {novoSalario.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajusteSalario.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: 4 %");
            }
        }
    }
}
