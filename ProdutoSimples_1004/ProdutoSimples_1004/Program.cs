using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoSimples_1004
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32 (Console.ReadLine());
            int b = Convert.ToInt32 (Console.ReadLine());
            int prod;

            prod = a * b;

            Console.WriteLine ($"PROD = { prod}");
        }
    }
}
