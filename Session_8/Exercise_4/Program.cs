using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            ProcessRepositories().Wait();        
        }

    private static async Task ProcessRepositories()
    {
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
    client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
    var serializer = new DataContractJsonSerializer(typeof(List<Username>));
    var streamTask = client.GetStreamAsync("https://jsonplaceholder.typicode.com/users");
    var repositories = serializer.ReadObject(await streamTask) as List<Username>;

    foreach (var repo in repositories)
    Console.WriteLine(repo.name + "\n" + repo.email);
    }
    }
}