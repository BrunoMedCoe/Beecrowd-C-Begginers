using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OMaior_1013
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] Maior = Console.ReadLine().Split(' ');
            int a = int.Parse(Maior[0]);
            int b = int.Parse(Maior[1]);
            int c = int.Parse(Maior[2]);

            int MaiorAB = (a + b + Math.Abs(a - b)) / 2;
            int OMaior = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;

            Console.WriteLine($"{OMaior} eh o maior");
        }
    }
}