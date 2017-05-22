using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace RestClient
{
    class Program
    {
        private const string URI = "https://api.github.com/users/juancarlospalomo/repos"; //https://api.github.com/orgs/dotnet/repos

        private static async Task<List<Repository>> ProcessRepositoriesAsync()
        {
            var serializer = new DataContractJsonSerializer(typeof(List<Repository>));

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json")
            );
            client.DefaultRequestHeaders.Add("User-Agent", "juancarlospalomo repository reporter");

            var streamTask = client.GetStreamAsync(URI);

            var repositories = serializer.ReadObject(await streamTask) as List<Repository>;

            return repositories;
        }

        static void Main(string[] args)
        {
            var repositories = ProcessRepositoriesAsync().Result;

            foreach (var repo in repositories)
            {
                Console.WriteLine($"{repo.Name} {repo.Description} {repo.LastPush}");
            }

            Console.WriteLine("Finished");
        }
    }
}
