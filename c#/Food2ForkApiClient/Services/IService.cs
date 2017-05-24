using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Food2ForkApiClient
{
    public interface IService {
        Task<List<Recipe>> SearchAsync(string pattern);
    }

}