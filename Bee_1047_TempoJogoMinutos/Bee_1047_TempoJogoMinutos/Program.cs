using System;

namespace Bee_1047_TempoJogoMinutos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] jogo = Console.ReadLine().Split(' ');
            int hora1 = int.Parse(jogo[0]);
            int min1 = int.Parse(jogo[1]);
            int hora2 = int.Parse(jogo[2]);
            int min2 = int.Parse(jogo[3]);

            int tempo, temp1, temp2, horaTotal, minTotal;

            if ((hora2 <= hora1) && (min2 <= min1))
            {
                hora2 = hora2 + 24;
            }
            else if (min2 <= min1)
            {
                min2 = min2 + 60;
                hora2 = hora2 - 1;
            }
            
            temp1 = ((hora1 * 3600) + (min1 * 60));
            temp2 = ((hora2 * 3600) + (min2 * 60));

            tempo = (temp2 - temp1);
            horaTotal = (tempo / 3600);
            minTotal = ((tempo - (horaTotal * 3600)) / 60);

            Console.WriteLine($"O JOGO DUROU {horaTotal} HORA(S) E {minTotal} MINUTO(S)");
        }
    }
}
