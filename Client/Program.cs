using System;
using System.IO;
using System.Net.Http;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("http://localhost:51369/").Result;
            var content = response.Content.ReadAsStringAsync().Result;

        }
    }
}
