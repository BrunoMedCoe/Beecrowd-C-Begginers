using System;

namespace Bee_1066_ParesImparesPositivosNegativos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int par = 0;
            int impar = 0;
            int positivo = 0;
            int negativo = 0;
            int[] numero = new int[5];

            for ( int i = 0; i < numero.Length; i++ )
            {
                numero[i] = int.Parse(Console.ReadLine());

                if (numero[i] % 2 == 0)
                {
                    par++;
                          
                }
                if (numero[i] % 2 != 0)
                {
                    impar++;
                }
                if (numero[i] > 0)
                {
                    positivo++;
                }
                if (numero[i] < 0)
                {
                    negativo++;
                }
            }

            Console.WriteLine($"{par} valor(es) par(es)");
            Console.WriteLine($"{impar} valor(es) impar(es)");
            Console.WriteLine($"{positivo} valor(es) positivo(s)");
            Console.WriteLine($"{negativo} valor(es) negativo(s)");
        }
    }
}
