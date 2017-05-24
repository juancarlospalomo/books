using System;

namespace Food2ForkApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RecipeServices recipeServices = new RecipeServices();
            var recipes = recipeServices.SearchAsync("rice").Result;

            foreach (Recipe recipe in recipes) {
                Console.WriteLine($"{recipe.title} : {recipe.rank} | {recipe.imageUrl}");
            }
        }
    }
}
