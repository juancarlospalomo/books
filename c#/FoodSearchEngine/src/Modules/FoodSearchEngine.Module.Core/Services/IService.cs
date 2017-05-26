using System;
using System.Collections.Generic;
using FoodSearchEngine.Module.Core.Models;
using System.Threading.Tasks;

namespace FoodSearchEngine.Module.Core.Services
{
    public interface IService<Entity>
    {
        Task<List<Entity>> SearchAsync(string query);
        Task<Entity> GetAsync(string id);
    }
}