using System;

namespace Bee_1114_SenhaFixa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string senhaCorreta = "2002";
            string senha;

            do
            {
                senha = Console.ReadLine();

                if (senha != senhaCorreta)
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
            while (senha != senhaCorreta);

            Console.WriteLine("Acesso Permitido");
        }
    }
}