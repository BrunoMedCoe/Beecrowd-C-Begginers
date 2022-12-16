using System;
using System.Linq;

namespace Bee_SortSimples_1042
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] crescente = Console.ReadLine().Split(' ');
            int N1 = int.Parse(crescente[0]);
            int N2 = int.Parse(crescente[1]);
            int N3 = int.Parse(crescente[2]);

            int[] valores = new int[] { N1, N2, N3 };

            Array.Sort(valores);

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < crescente.Length; i++)
            {
                Console.WriteLine(crescente[i]);
            }
        }
    }
}
