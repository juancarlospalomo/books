using System;
using Xunit;
using FoodSearchEngine.Module.Core.Services;

namespace test
{
    public class UnitTestRecipeApiService
    {
        [Fact]
        public void TestSearchReturnResult()
        {
            var service = new RecipeApiService();
            var result = service.SearchAsync("").Result;
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }
    }
}
