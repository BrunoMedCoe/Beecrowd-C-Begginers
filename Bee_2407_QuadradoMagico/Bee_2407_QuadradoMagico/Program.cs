using System;

namespace Bee_2407_QuadradoMagico
{
    public class Program
    {
        public static Boolean QuadradoMagico(int[,] matrix)
        {
            int soma1 = 0;
            int soma2 = 0;
            int i = 0;
            //somar elementos da primeira linha
            for (int j = 0; j < matrix.Length; j++)
            {
                soma1 += matrix[0, j];
            }
            //somar as demais linhas
            for (i = 1; i < matrix.Length; i++)
            {
                soma2 = 0;
                for (int j = 0; j < matrix.Length; j++)
                {
                    soma2 += matrix[i, j];
                }
                if (soma2 != soma1)
                {
                    return false;   //não é quadrado mágico
                }
            }
            //somar as colunas
            for (int j = 0; j < matrix.Length; j++)
            {
                soma2 = 0;
                
                for (i = 0; i < matrix.Length; i++)
                {
                    soma2 += matrix[i, j];
                }
                if (soma2 != soma1)
                {
                    return false;
                }
            }
            // somar a diagonal principal
            soma2 = 0;
            
            for (i = 0; i < matrix.Length; i++)
            {
                soma2 += matrix[i, i];
            }
            if (soma2 != soma1)
            {
                return false;
            }
            // somar a diagonal secundaria
            soma2= 0;
            i = 0;
            for (int j = matrix.Length - 1; j >= 0; j--)
            {
                soma2 += matrix[i, j];
                i++;
            }
            if (soma2 != soma1)
            {
                return false;
            }
            return true;    //é quadrado magico
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] quadradoMagico = new int[n,n];
        }
    }
}