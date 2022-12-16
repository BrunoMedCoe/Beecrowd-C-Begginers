using System;

namespace Bee_1046_TempoJogo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] jogo = Console.ReadLine().Split(' ');
            int inicio = int.Parse(jogo[0]);
            int final = int.Parse(jogo[1]);

            int tempo;

            if (inicio < final)
            {
                tempo = (((final * 60) - (inicio * 60)) / 60);
                Console.WriteLine($"O JOGO DUROU {tempo} HORA(S)");
            }
            else if (inicio > final)
            {
                tempo = ((24 - inicio) + final);
                Console.WriteLine($"O JOGO DUROU {tempo} HORA(S)");
            }
            else
            {
                tempo = 24;
                Console.WriteLine($"O JOGO DUROU {tempo} HORA(S)");
            }
        }
    }
}
