using System;
using FoodSearchEngine.Module.Core.Models;
using FoodSearchEngine.Module.Core.Services;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCanBeDeserialized();
            //TestGetShouldReturnResult();
            Console.WriteLine("Hello World!");
        }

        static void TestCanBeDeserialized()
        {
            string json = "{\"recipe\": {\"publisher\": \"Closet Cooking\", \"f2f_url\": \"http://food2fork.com/view/35171\", \"ingredients\": [\"1/4 cup cooked shredded chicken, warm\", \"1 tablespoon hot sauce\", \"1/2 tablespoon mayo (optional)\",\"1 tablespoon carrot, grated\", \"1 tablespoon celery, sliced\", \"1 tablespoon green or red onion, sliced or diced\", \"1 tablespoon blue cheese, room temperature, crumbled\", \"1/2 cup cheddar cheese, room temperature, grated\", \"2 slices bread\", \"1 tablespoon butter, room temperature\n\"], \"source_url\": \"http://www.closetcooking.com/2011/08/buffalo-chicken-grilled-cheese-sandwich.html\", \"recipe_id\": \"35171\", \"image_url\": \"http://static.food2fork.com/Buffalo2BChicken2BGrilled2BCheese2BSandwich2B5002B4983f2702fe4.jpg\", \"social_rank\": 100.0, \"publisher_url\": \"http://closetcooking.com\", \"title\": \"Buffalo Chicken Grilled Cheese Sandwich\"}}";
            RecipesResult recipesResult = new RecipesResult();
            var result = recipesResult.CanBeDeserialized(json);

            Console.WriteLine($"Can be deserialized: {result}");
        }

        static void TestGetShouldReturnResult()
        {
            var service = new RecipeApiService();
            var result = service.SearchAsync("").Result;

            if (result.count > 0)
            {
                var recipe = service.GetAsync(result.recipes[0].id).Result;
            }
        }
    }
}
