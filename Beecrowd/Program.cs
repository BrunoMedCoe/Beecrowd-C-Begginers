using System.Globalization;

namespace Beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 9;
            string resposta;

            if(valor%3 == 0 && valor%5 == 0)
            {
                resposta = "FizzBuzz";
            } else if (valor%3 == 0)
            {
                resposta = "Fizz";
            } else if (valor%5 == 0)
            {
                resposta = "Buzz";
            } else
            {
                resposta = "none";
            }
            Console.WriteLine(resposta);
        }
    }
}
