using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Healthy() { id = 1, name = "Recipe 1" };
            Console.WriteLine($"{recipe.ToString()}");
            Console.WriteLine($"{recipe.find()}");
        }
    }
}   
