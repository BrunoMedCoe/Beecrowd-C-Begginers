using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lanche_1038
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Codigo, Quantidade;

            double Valor = 0;
            double Soma;

            string[] Total = Console.ReadLine().Split(' ');
            Codigo = int.Parse(Total[0]);
            Quantidade= int.Parse(Total[1]);

            if (Codigo == 1)
            {
                Valor = 4.00;
            }
            else if (Codigo == 2)
            {
                Valor = 4.50;
            }
            else if (Codigo == 3)
            {
                Valor = 5.00;
            }
            else if (Codigo == 4)
            {
                Valor = 2.00;
            }
            else if (Codigo == 5)
            {
                Valor = 1.50;
            }

            Soma = Valor * Quantidade;

            Console.WriteLine($"Total: R$ {Soma.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}