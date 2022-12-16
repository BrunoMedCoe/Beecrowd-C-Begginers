using System;

namespace Bee_1134_TipoCombustivel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            do
            {
                numero = int.Parse(Console.ReadLine());

                if (numero >= 1 && numero <= 3)
                {
                    if (numero == 1)
                    {
                        alcool++;
                    }
                    else if (numero == 2)
                    {
                        gasolina++;
                    }
                    else if (numero == 3)
                    {
                        diesel++;
                    }
                }
            }
            while (numero != 4);
            {
                Console.WriteLine("MUITO OBRIGADO");
                Console.WriteLine($"Alcool: {alcool}");
                Console.WriteLine($"Gasolina: {gasolina}");
                Console.WriteLine($"Diesel: {diesel}");
            }
        }
    }
}
