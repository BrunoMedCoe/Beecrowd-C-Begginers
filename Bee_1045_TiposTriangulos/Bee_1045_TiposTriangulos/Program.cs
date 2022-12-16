using System;

namespace Bee_1045_TiposTriangulos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double A = double.Parse(entrada[0]);
            double B = double.Parse(entrada[1]);
            double C = double.Parse(entrada[2]);

            if ( C > B && C > A)
            {
                double aux = C;
                C = A;
                A = aux;
            } else if ( B > A && B > C )
            {
                double aux = B;
                B = A;
                A = aux;
            }
            if (C > B)
            {
                double aux = C;
                C = B;
                B = aux;
            }

            if (A >= (B + C))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
                return;
            }
            if ((A * A) == ((B * B) + (C * C)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            } else if ((A * A) > ((B * B) + (C * C)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            } else if ((A * A) < ((B * B) + (C * C)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if ((A == B) && (A == C))
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            } else if (((A == B) && (A != C)) || ((A == C) && (A != B)) || ((B == C) && (B != A)))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
