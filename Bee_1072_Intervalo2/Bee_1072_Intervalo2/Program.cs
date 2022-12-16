using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x = 0;
        int y = 0;

        int[] vet = new int[n];

        for (int i = 0; i < vet.Length; i++)
        {
            vet[i] = int.Parse(Console.ReadLine());

            if (vet[i] >= 10 && vet[i] <= 20)
            {
                x++;
            }
            else
            {
                y++;
            }
        }

        Console.WriteLine($"{x} in");
        Console.WriteLine($"{y} out");
    }
}