using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Media3_1040
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] Notas = Console.ReadLine().Split(' ');
            double N1 = double.Parse(Notas[0], CultureInfo.InvariantCulture);
            double N2 = double.Parse(Notas[1], CultureInfo.InvariantCulture);
            double N3 = double.Parse(Notas[2], CultureInfo.InvariantCulture);
            double N4 = double.Parse(Notas[3], CultureInfo.InvariantCulture);

            double Media = Math.Round((2 * N1 + 3 * N2 + 4 * N3 + 1 * N4) / (2 + 3 + 4 + 1), 1);
            Console.WriteLine($"Media: {Media.ToString("f1", CultureInfo.InvariantCulture)}");

            if (Media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (Media < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (Media >= 5 && Media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");

                double Exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double MediaFinal = Math.Round(((Media + Exame) / 2), 1);

                if (MediaFinal >= 5.0)
                {
                    Console.WriteLine($"Nota do exame: {Exame.ToString("f1", CultureInfo.InvariantCulture)}");
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {MediaFinal.ToString("f1", CultureInfo.InvariantCulture)}");
                }
                else
                {
                    Console.WriteLine($"Nota do exame: {Exame.ToString("f1", CultureInfo.InvariantCulture)}");
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {MediaFinal.ToString("f1", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}

