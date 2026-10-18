using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading;

namespace Async_i_Await
{
    internal class Program
    {
        //public async Task<string> FetchAsync(HttpClient client, string url)
        //{
        //    return await client.GetStringAsync(url);
        //}

        public async Task<int> GetValueAsync()
        {
            await Task.Delay(1000); // Simulate an asynchronous operation
            return 42; // Return a value after the delay
        }
        
        public async Task UseASync()
        {
            Console.WriteLine("Before");
            int v = await GetValueAsync();
            Console.WriteLine($"After {v}");
        }
        public static async Task Main(string[] args)
        {
            var program = new Program();
            await program.UseASync();
        }
    }
}
