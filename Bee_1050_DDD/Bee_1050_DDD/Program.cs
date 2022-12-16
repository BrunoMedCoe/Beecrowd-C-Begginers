using System;

namespace Bee_1050_DDD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string destination;
            int number = int.Parse(Console.ReadLine());

            if (number == 61)
            {
                destination = "Brasilia";
                Console.WriteLine(destination);
            }
            else if (number == 71)
            {
                destination = "Salvador";
                Console.WriteLine(destination);
            }
            else if (number == 11)
            {
                destination = "Sao Paulo";
                Console.WriteLine(destination);
            }
            else if (number == 21)
            {
                destination = "Rio de Janeiro";
                Console.WriteLine(destination);
            }
            else if (number == 32)
            {
                destination = "Juiz de Fora";
                Console.WriteLine(destination);
            }
            else if (number == 19)
            {
                destination = "Campinas";
                Console.WriteLine(destination);
            }
            else if (number == 27)
            {
                destination = "Vitoria";
                Console.WriteLine(destination);
            }
            else if (number == 31)
            {
                destination = "Belo Horizonte";
                Console.WriteLine(destination);
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}
