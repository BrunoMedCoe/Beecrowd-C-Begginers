using System;

namespace Bee_1150_UltrapassandoZ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x, z, y;
            int cont = 0;

            x = int.Parse(Console.ReadLine());

            do
            {
                z = int.Parse(Console.ReadLine());
            }
            while (z <= x);

            y = x;
            x = 0;

            while (z >= x)
            {
                x += y++;
                cont++;
            }

            Console.WriteLine(cont);
        }
    }
}