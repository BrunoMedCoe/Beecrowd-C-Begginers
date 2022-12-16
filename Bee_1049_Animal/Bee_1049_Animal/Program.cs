using System;

namespace Bee_1049_Animal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string classe1, classe2, classe3, animal;

            classe1 = Convert.ToString(Console.ReadLine());
            classe2 = Convert.ToString(Console.ReadLine());
            classe3 = Convert.ToString(Console.ReadLine());

            if (classe1 == "vertebrado")
            {
                if (classe2 == "ave")
                {
                    if (classe3 == "carnivoro")
                    {
                        animal = "aguia";
                        Console.WriteLine($"{animal}");
                    }
                    else if (classe3 == "onivoro")
                    {
                        animal = "pomba";
                        Console.WriteLine($"{animal}");
                    }
                }
            }

            if (classe1 == "vertebrado")
            {
                if (classe2 == "mamifero")
                {
                    if (classe3 == "onivoro")
                    {
                        animal = "homem";
                        Console.WriteLine($"{animal}");
                    }
                    else if (classe3 == "herbivoro")
                    {
                        animal = "vaca";
                        Console.WriteLine($"{animal}");
                    }
                }
            }

            if (classe1 == "invertebrado")
            {
                if (classe2 == "inseto")
                {
                    if (classe3 == "hematofago")
                    {
                        animal = "pulga";
                        Console.WriteLine($"{animal}");
                    }
                    else if (classe3 == "herbivoro")
                    {
                        animal = "lagarta";
                        Console.WriteLine($"{animal}");
                    }
                }
            }

            if (classe1 == "invertebrado")
            {
                if (classe2 == "anelideo")
                {
                    if (classe3 == "hematofago")
                    {
                        animal = "sanguessuga";
                        Console.WriteLine($"{animal}");
                    }
                    else if (classe3 == "onivoro")
                    {
                        animal = "minhoca";
                        Console.WriteLine($"{animal}");
                    }
                }
            }
        }
    }
}