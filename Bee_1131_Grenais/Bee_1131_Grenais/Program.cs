using System;

namespace Bee_1131_Grenais
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int nI, nG, inter, gremio, empate, grenal, alternativa;
            nI = nG = inter = gremio = empate = grenal = alternativa = 0;

            do
            {
                string[] gols = Console.ReadLine().Split(' ');
                nI = int.Parse(gols[0]);
                nG = int.Parse(gols[1]);

                if (nI > nG)
                {
                    inter++;
                    grenal++;
                }
                else if (nI < nG)
                {
                    gremio++;
                    grenal++;
                }
                else
                {
                    empate++;
                    grenal++;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                alternativa = int.Parse(Console.ReadLine());
            }
            while (alternativa == 1);

            if (inter > gremio)
            {
                Console.WriteLine($"{grenal} grenais");
                Console.WriteLine($"Inter:{inter}");
                Console.WriteLine($"Gremio:{gremio}");
                Console.WriteLine($"Empates:{empate}");
                Console.WriteLine("Inter venceu mais");
            }
            else if (inter < gremio)
            {
                Console.WriteLine($"{grenal} grenais");
                Console.WriteLine($"Inter:{inter}");
                Console.WriteLine($"Gremio:{gremio}");
                Console.WriteLine($"Empates:{empate}");
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine($"{grenal} grenais");
                Console.WriteLine($"Inter:{inter}");
                Console.WriteLine($"Gremio:{gremio}");
                Console.WriteLine($"Empates:{empate}");
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
