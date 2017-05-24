using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Microsoft.Extensions.Logging;

namespace Food2ForkApiClient
{
    public class RecipeServices : IService
    {
        //TODO: Attributes
        public enum ApiCommand
        {
            Search,
            Get
        }

        #region "Constants"

        //Example of GET Request: http://food2fork.com/api/search?key=16fb9daf53cd0cd3a321933ec630f2a1&q=cocido
        private const string API_KEY = "16fb9daf53cd0cd3a321933ec630f2a1";
        private const string API_KEY_PARAM_NAME = "key";
        private const string SEARCH_PARAM_NAME = "q";
        private const string URI_API = "http://food2fork.com/api/";
        private const string API_SEARCH_COMMAND = "search";
        private const string API_GET_COMMAND = "get";
        private const string SEARCH_URL_PARAM = "q";
        private const string GET_URL_PARAM = "rId";

        #endregion

        #region "Private members"

        private ILogger<RecipeServices> _logger;

        #endregion

        public RecipeServices(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<RecipeServices>();
        }

        //TODO: Remove
        private string BuildUrl(ApiCommand command, string value)
        {
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

        public async Task<List<Recipe>> SearchAsync(string pattern)
        {
            var serializer = new DataContractJsonSerializer(typeof(ResultModel));

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("Accept-Content", "application/json");

            _logger.LogInformation($"Searching {pattern}");

            var stream = httpClient.GetStreamAsync(BuildUrl(ApiCommand.Search, pattern));

            var result = serializer.ReadObject(await stream) as ResultModel;

            return result.recipes;
        }

    }

}