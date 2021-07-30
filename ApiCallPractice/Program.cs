using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace ApiCallPractice
{
    class User 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address address { get; set; }
        public Company company { get; set; }

    }

    class Address 
    {
        public string City { get; set; }
        public Geo geo { get; set; }
    }

    class Geo 
    {
        public string lat { get; set; }
        public string lng { get; set; }

    }

    class Company
    {

        public string Name { get; set; }
        public string Bs { get; set; }
        public string CatchPhrase { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:3000");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            User user = new User() { Name = "Kiri" };
            HttpResponseMessage response = httpClient.PostAsJsonAsync("/data", user).Result;
            string content = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(content);
            //List<User> data = JsonConvert.DeserializeObject<List<User>>(content);
            //foreach(User d in data)
            //{
            //    Console.WriteLine(d.Id +" "+ d.Name + " " + d.address.City + " " + d.address.geo.lat + " " + d.company.Name);
            //}
       
        }
    }
}
