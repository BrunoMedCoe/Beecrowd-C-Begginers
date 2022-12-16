using System;

namespace Bee_1061_TempoEvento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int dInicial, hInicial, mInicial, sInicial, dFinal, hFinal, mFinal, sFinal;
            string dia;
            char x;

            string[] linha1 = Console.ReadLine().Split(' ');
            dia = Convert.ToString(linha1[0]);
            dInicial = int.Parse(linha1[1]);

            string[] linha2 = Console.ReadLine().Split(' ');
            hInicial= int.Parse(linha2[0]);
            x = char.Parse(linha2[1]);
            mInicial= int.Parse(linha2[2]);
            x = char.Parse(linha2[3]);
            sInicial= int.Parse(linha2[4]);

            string[] linha3 = Console.ReadLine().Split(' ');
            dia = Convert.ToString(linha3[0]);
            dFinal= int.Parse(linha3[1]);

            string[] linha4 = Console.ReadLine().Split(' ');
            hFinal = int.Parse(linha4[0]);
            x = char.Parse(linha4[1]);
            mFinal = int.Parse(linha4[2]);
            x = char.Parse(linha4[3]);
            sFinal = int.Parse(linha4[4]);

            sInicial = sFinal - sInicial;
            mInicial = mFinal - mInicial;
            hInicial = hFinal - hInicial;
            dInicial = dFinal - dInicial;

            if (sInicial < 0)
            {
                sInicial += 60;
                mInicial--;
            }
            if (mInicial < 0)
            {
                mInicial += 60;
                hInicial--;
            }
            if (hInicial < 0)
            {
                hInicial += 24;
                dInicial--;
            }

            Console.WriteLine($"{dInicial} dia(s)");
            Console.WriteLine($"{hInicial} hora(s)");
            Console.WriteLine($"{mInicial} minuto(s)");
            Console.WriteLine($"{sInicial} segundo(s)");
        }
    }
}