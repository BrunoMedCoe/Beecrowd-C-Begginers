using System;

namespace Bee_1149_SomandoInteirosConsecutivos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 0;
            int n = 0;
            int soma = 0;
            int cont = 1;
            
            string[] linhaEntrada = Console.ReadLine().Split(' ');
            a = int.Parse(linhaEntrada[0]);
            n = int.Parse(linhaEntrada[1]);

            while (n <= 0)
            {
                cont++;
                n = int.Parse(linhaEntrada[cont]);
            }
            for (int i = 0; i <= n- 1; i++)
            {
                soma += (a + i);
            }

            Console.WriteLine(soma);
        }
    }
}
