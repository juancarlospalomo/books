using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using FoodSearchEngine.Module.Core.Models;

namespace FoodSearchEngine.Module.Core.Services
{
    public class RecipeApiService : IService<Entity>
    {
        public async Task<List<Entity>> SearchAsync(string query)
        {
            await Task.Delay(1000);
            return null;
        }

        public async Task<Entity> GetAsync(string id)
        {
            await Task.Delay(1000);
            return null;
        }

    }
}