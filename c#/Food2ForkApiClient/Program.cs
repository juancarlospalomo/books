using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Food2ForkApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setup DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IService, RecipeServices>()
                .BuildServiceProvider();

            serviceProvider.GetService<ILoggerFactory>().AddConsole(LogLevel.Debug);

            var recipeServices = serviceProvider.GetService<IService>();

            var recipes = recipeServices.SearchAsync("rice").Result;

            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine($"{recipe.title} : {recipe.rank} | {recipe.imageUrl}");
            }
        }
    }
}
