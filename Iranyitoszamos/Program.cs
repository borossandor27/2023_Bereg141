using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Iranyitoszamos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            irszam();
            Console.WriteLine("vége");
            Console.ReadLine();
        }
       private static async  void irszam()
        {
            
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, "http://api.zippopotam.us/us/98121");
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                Console.WriteLine(await response.Content.ReadAsStringAsync());

            
        }

    }
}
