using System;

namespace Bee_1052_Mes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] month = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            int i = int.Parse(Console.ReadLine());

            i--;
            Console.WriteLine(month[i]);
        }
    }
}
