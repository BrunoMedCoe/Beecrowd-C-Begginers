using System;
using System.Globalization;

namespace CoordenadasPonto_1041
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] Coordenadas = Console.ReadLine().Split(' ');
            double X = double.Parse(Coordenadas[0]);
            double Y = double.Parse(Coordenadas[1]);

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if ( X  < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (X == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (Y == 0)
            {
                Console.WriteLine("Eixo X");
            }
        }
    }
}