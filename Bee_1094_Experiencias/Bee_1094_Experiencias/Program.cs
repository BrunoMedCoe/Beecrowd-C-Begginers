using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        int coelho = 0;
        int rato = 0;
        int sapo = 0;
        int C = 0;
        int R = 0;
        int S = 0;
        int quantidade, total;

        float percentualC, percentualR, percentualS;

        char tipo;
        
        int n = int.Parse(Console.ReadLine());

        int[] vet = new int[n];

        for (int i = 0; i < n; i++)
        {
            string[] array = Console.ReadLine().Split(' ');

            quantidade = int.Parse(array[0]);
            tipo = char.Parse(array[1]);

            if (tipo == 'C')
            {
                C++;
                coelho += quantidade;
            }
            else if (tipo == 'R')
            {
                R++;
                rato += quantidade;
            }
            else if (tipo == 'S')
            {
                S++;
                sapo += quantidade;
            }
        }

        total = (coelho + rato + sapo);

        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {coelho}");
        Console.WriteLine($"Total de ratos: {rato}");
        Console.WriteLine($"Total de sapos: {sapo}");

        percentualC = (float)coelho / total * 100;
        percentualR = (float)rato / total * 100;
        percentualS = (float)sapo/ total * 100;

        Console.WriteLine($"Percentual de coelhos: {percentualC.ToString("f2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de ratos: {percentualR.ToString("f2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de sapos: {percentualS.ToString("f2", CultureInfo.InvariantCulture)} %");
    }
}
