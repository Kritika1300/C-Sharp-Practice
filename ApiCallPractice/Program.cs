using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Refit;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    public class Data
    {
        public string Login { get; set; }
        public string Followers_Url { get; set; }
    }

    public interface IGitHubAPI
    {
        [Headers("User-Agent: Awesome Octocat App")]
        [Get("/users/Kritika1300/followers")]
        Task<List<Data>> GetData();

        [Headers("User-Agent: Awesome Octocat App")]
        [Get("/users/{uname}/followers")]
        Task<List<Data>> GetData(string uname);

    }

    class Test
    {

        public static async Task Main()
        {
                var git = RestService.For<IGitHubAPI>("https://api.github.com");
                var followers = await git.GetData("Kritika1300");

                foreach (var i in followers)
                {
                    Console.WriteLine("Follower Name : " + i.Login + i.Followers_Url);
                }

        }
   
    }


}

