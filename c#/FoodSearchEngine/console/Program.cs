using System;
using System.Text;
using FoodSearchEngine.Module.Core.Models;
using FoodSearchEngine.Module.Core.Services;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCanBeDeserialized();
            TestGetShouldReturnResult();
            Console.WriteLine("Finished!");
        }

        static string BuildStaticJson() {
            StringBuilder builder = new StringBuilder();
            builder.Append("{");
            builder.Append("  \"recipe\": {");
            builder.Append("    \"publisher\": \"Closet Cooking\",");
            builder.Append("    \"f2f_url\": \"http://food2fork.com/view/35171\",");
            builder.Append("    \"ingredients\": [");
            builder.Append("      \"1/4 cup cooked shredded chicken, warm\",");
            builder.Append("      \"1 tablespoon hot sauce\",");
            builder.Append("      \"1/2 tablespoon mayo (optional)\",");
            builder.Append("      \"1 tablespoon carrot, grated\",");
            builder.Append("      \"1 tablespoon carrot, grated\",");
            builder.Append("      \"1 tablespoon green or red onion, sliced or diced\",");
            builder.Append("      \"1 tablespoon blue cheese, room temperature, crumbled\",");
            builder.Append("      \"1/2 cup cheddar cheese, room temperature, grated\",");
            builder.Append("      \"2 slices bread\",");
            builder.Append("      \"1 tablespoon butter, room temperature\"");
            builder.Append("    ],");
            builder.Append("    \"source_url\": \"http://www.closetcooking.com/2011/08/buffalo-chicken-grilled-cheese-sandwich.html\",");
            builder.Append("    \"recipe_id\": \"35171\",");
            builder.Append("    \"image_url\": \"http://static.food2fork.com/Buffalo2BChicken2BGrilled2BCheese2BSandwich2B5002B4983f2702fe4.jpg\",");
            builder.Append("    \"social_rank\": 100.0,");
            builder.Append("    \"publisher_url\": \"http://closetcooking.com\",");
            builder.Append("    \"title\": \"Buffalo Chicken Grilled Cheese Sandwich\"");
            builder.Append("  }");
            builder.Append("}");
            return builder.ToString();
        }

        static void TestCanBeDeserialized()
        {
            string json = BuildStaticJson();
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
