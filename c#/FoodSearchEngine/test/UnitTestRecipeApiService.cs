using System;
using Xunit;
using FoodSearchEngine.Module.Core.Services;

namespace test
{
    public class UnitTestRecipeApiService
    {
        [Fact]
        public void TestSearchShouldReturnResult()
        {
            var service = new RecipeApiService();
            var result = service.SearchAsync("").Result;
            Assert.NotNull(result);
            Assert.NotEmpty(result.recipes);
            Assert.True(result.count > 0);
        }

        [Fact]
        public void TestGetShouldReturnResult()
        {
            var service = new RecipeApiService();
            var result = service.SearchAsync("").Result;

            if (result.count > 0)
            {
                var recipe = service.GetAsync(result.recipes[0].id).Result;
                Assert.Equal(result.recipes[0].id, recipe.id);
            }
        }
    }
}
