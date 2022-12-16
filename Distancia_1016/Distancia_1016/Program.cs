using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Distancia_1016
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int distancia, tempo;

            distancia = int.Parse(Console.ReadLine());
            tempo = distancia * 2;

            Console.WriteLine($"{tempo} minutos");
        }
    }
}