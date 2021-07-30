using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ConsoleProgram
{
    public class Data
    {
        public string Login { get; set; }
        public string  Followers_Url{ get; set; }
    }

    class Test
    {

        public static void Main()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.github.com");
            var requestheader = httpClient.DefaultRequestHeaders.ToString();
            Console.WriteLine(requestheader);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("User-Agent", "anything");
            requestheader = httpClient.DefaultRequestHeaders.ToString();
            Console.WriteLine(requestheader);

            HttpResponseMessage response = httpClient.GetAsync("/users/Kritika1300/followers").Result; // synchronous because of .Result as it blocks the execution thread (similar to Wait method)
            var header = response.Headers; // response headers
            var content = response.Content.ReadAsStringAsync().Result; //response content
            List<Data> followers = JsonConvert.DeserializeObject<List<Data>>(content);
            foreach (var i in followers)
            {
                Console.WriteLine("Follower Name : " + i.Login + i.Followers_Url);
            }

        }
        // ReadAsStringAsync returns Task<string> // .Result 
        // GetAsync returns Task<HttpResponseMessage>
        // DefaultRequestHeaders returns HttpRequestHeaders
    }

  
}