using System;
using System.Globalization;

namespace Bee_1079_MediasPonderadas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float n1, n2, n3, mPonderada;
            
            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split(' ');

                n1 = float.Parse(array[0], CultureInfo.InvariantCulture);
                n2 = float.Parse(array[1], CultureInfo.InvariantCulture);
                n3 = float.Parse(array[2], CultureInfo.InvariantCulture);

                mPonderada = ((n1*2) + (n2*3) + (n3*5)) / 10;

                Console.WriteLine(mPonderada.ToString("f1", CultureInfo.InvariantCulture));
            }
        }
    }
}