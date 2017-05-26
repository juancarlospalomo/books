using System;
using System.Collections.Generic;
using FoodSearchEngine.Module.Core.Models;
using System.Threading.Tasks;

namespace FoodSearchEngine.Module.Core.Services
{
    public interface IService<Entity>
    {
        Task<RecipesResult> SearchAsync(string query);
        Task<Recipe> GetAsync(string id);
    }
}