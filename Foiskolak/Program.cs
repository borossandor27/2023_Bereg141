using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Foiskolak;


namespace Foiskolak
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            List<Foiskola> foiskolak = new List<Foiskola>();
            foiskolak = await foiskolaAdatok();
            foreach (Foiskola foiskola in foiskolak)
            {
                Console.WriteLine($"{foiskola.Name} - {foiskola.Country}");
            }
            await Console.Out.WriteLineAsync("program vége!");
            Console.ReadLine();
        }

        private static async Task<List<Foiskola>> foiskolaAdatok()
        {
            List<Foiskola> foiskolak = new List<Foiskola>();
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://universities.hipolabs.com/search?country=hungary");
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                foiskolak = Foiskola.FromJson(jsonString).ToList();
            }
            return foiskolak;
        }
    }
}
