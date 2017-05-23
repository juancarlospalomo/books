using System;

namespace Food2ForkApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RecipeServices recipeServices = new RecipeServices();
            Console.WriteLine(recipeServices.BuildUrl());
        }
    }
}
