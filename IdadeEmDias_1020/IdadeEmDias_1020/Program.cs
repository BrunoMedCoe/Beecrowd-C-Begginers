using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace IdadeEmDias_1020
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Idade, anos, meses, dias, resto;

            Idade = int.Parse(Console.ReadLine());

            anos = Idade / 365;
            resto = Idade % 365;

            meses = resto / 30;
            resto = resto % 30;

            dias = resto;

            Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
        }
    }
}