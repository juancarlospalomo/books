using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using FoodSearchEngine.Module.Core.Models;

namespace FoodSearchEngine.Module.Core.Services
{
    public class RecipeApiService : IService<Recipe>
    {

        private enum CommandName
        {
            Get,
            Search
        };
        //TODO: Attributes
        public enum ApiCommand
        {
            Search,
            Get
        }

        #region "Constants"
        //Example of GET Request: http://food2fork.com/api/search?key=16fb9daf53cd0cd3a321933ec630f2a1&q=cocido
        private const string API_KEY = "16fb9daf53cd0cd3a321933ec630f2a1";
        private const string URI_API = "http://food2fork.com/api/";
        private const string API_KEY_PARAM_NAME = "key";

        #endregion

        private string BuildUrl(ApiCommand command, string value)
        {
            const string API_SEARCH_COMMAND = "search";
            const string API_GET_COMMAND = "get";
            const string SEARCH_URL_PARAM = "q";
            const string GET_URL_PARAM = "rId";

            string url = URI_API;

            switch (command)
            {
                case ApiCommand.Search:
                    url += String.Format($"{API_SEARCH_COMMAND}?{API_KEY_PARAM_NAME}={API_KEY}&{SEARCH_URL_PARAM}={value}");
                    break;
                case ApiCommand.Get:
                    url += String.Format($"{API_GET_COMMAND}?{API_KEY_PARAM_NAME}={API_KEY}&{GET_URL_PARAM}={value}");
                    break;
                default:
                    url += API_SEARCH_COMMAND;
                    break;
            }

            return url;
        }

        public async Task<RecipesResult> SearchAsync(string query)
        {
            var serializer = new DataContractJsonSerializer(typeof(RecipesResult));

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("Accept-Content", "application/json");

            //_logger.LogInformation($"Searching {pattern}");

            var stream = httpClient.GetStreamAsync(BuildUrl(ApiCommand.Search, query));

            var result = serializer.ReadObject(await stream) as RecipesResult;

            return result;
        }

        public async Task<Recipe> GetAsync(string id)
        {
            var serializer = new DataContractJsonSerializer(typeof(RecipesResult));
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("Accept-Content", "application/json");

            var stream = httpClient.GetStreamAsync(BuildUrl(ApiCommand.Get, id));
            var result = serializer.ReadObject(await stream) as RecipesResult;

            return result.current;
        }

    }
}