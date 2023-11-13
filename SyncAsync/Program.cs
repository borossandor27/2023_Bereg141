using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1000, 9999);
            int b = rnd.Next(1000, 9999);
            Console.WriteLine($"Async: {CalculateSumAsync(a,b)}");
            Console.WriteLine($"\nSync: {CalculateSum(a, b)}");
            Console.WriteLine("program vége");
            Console.ReadLine();
        }
        // Synchronous method
        public static int CalculateSum(int a, int b)
        {
            return a + b;
        }

        // Asynchronous method
        public static async Task<int> CalculateSumAsync(int a, int b)
        {
            return await Task.Run(() => a + b);
        }
    }
}
