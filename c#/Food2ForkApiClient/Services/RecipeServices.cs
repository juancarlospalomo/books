using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Food2ForkApiClient
{

    public class RecipeServices
    {
        private enum CommandName
        {
            Get,
            Search
        };

        //Example of GET Request: http://food2fork.com/api/search?key=16fb9daf53cd0cd3a321933ec630f2a1&q=cocido
        private const string API_KEY = "16fb9daf53cd0cd3a321933ec630f2a1";
        private const string API_KEY_PARAM_NAME = "key";
        private const string SEARCH_PARAM_NAME = "q";
        private const string URL_API = "http://food2fork.com/api/";
        private const string URL_API_SEARCH = "search";
        private const string URL_API_GET = "get";
        
        //TODO: Remove
        public string BuildUrl()
        {
            return string.Format($"{URL_API}");
        }

        public async Task<List<Recipe>> SearchAsync(string pattern)
        {
            await System.Threading.Tasks.Task.Delay(1000);
            return null;
        }

    }

}