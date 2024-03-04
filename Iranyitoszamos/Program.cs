using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Iranyitoszamos;

namespace Iranyitoszamos
{
    internal class Program
    {
        static PostalCode postalCode=null;
        static void Main(string[] args)
        {
            string keresettIranyitoszam = "4220";
            irszam(keresettIranyitoszam);
            Console.WriteLine($"{postalCode.Places[0].PlaceName.ToString()} település irányítószáma: {keresettIranyitoszam}"   );
            Console.WriteLine("vége");
            Console.ReadLine();
        }
        private static async void irszam(string irszam)
        {
            string url = $"http://api.zippopotam.us/hu/{irszam}";
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string jsonString = await response.Content.ReadAsStringAsync();
            postalCode = PostalCode.FromJson(jsonString);
            
        }

    }
}
