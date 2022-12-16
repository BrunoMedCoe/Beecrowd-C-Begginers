using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diferenca_1007
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine()); 
            int D = Convert.ToInt32(Console.ReadLine());
            
            int diferenca = A * B - C * D;

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}