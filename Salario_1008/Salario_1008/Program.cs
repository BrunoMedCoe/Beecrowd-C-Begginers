using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Salario_1008
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int NumeroFuncionario = Convert.ToInt32(Console.ReadLine());
            int QntHorasTrabalhadas = Convert.ToInt32(Console.ReadLine());
            double ValorHorasTrabalhadas = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Salary = (QntHorasTrabalhadas * ValorHorasTrabalhadas);

            Console.WriteLine($"NUMBER = {NumeroFuncionario}\nSALARY = U$ {Salary.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}