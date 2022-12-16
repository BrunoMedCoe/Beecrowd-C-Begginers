using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConversaoTempo_1019
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N, horas, minutos, segundos, resto;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            resto = resto % 60;

            segundos = resto;

            Console.WriteLine(horas + " : " + minutos + " : " + segundos);
        }
    }
}
