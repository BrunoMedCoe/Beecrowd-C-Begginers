using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaSimples_1003
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int soma;

            soma = A + B;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}