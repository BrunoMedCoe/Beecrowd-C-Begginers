using System;

namespace Bee_1065_ParesCincoNumeros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int par = 0;
            int[] number = new int[5];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
                if (number[i] % 2 == 0)
                {
                    par++;
                }
            }

            Console.WriteLine($"{par} valores pares");
        }
    }
}
