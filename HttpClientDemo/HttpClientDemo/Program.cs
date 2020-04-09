using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientDemo
{
    class Program
    {
        static async Task Main()
        {
            using(var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "https://yummyanime.club/users/id13222");

                for (int i = 0; i < 1; i++)
                {
                    await GetContent(httpClient);
                    System.Threading.Thread.Sleep(4000);
                }
            }

            Console.ReadKey(true);
        }

        private static async Task GetContent(HttpClient httpClient)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://yummyanime.club/catalog");
                response.EnsureSuccessStatusCode(); // Высвобождает ресурсы если соеденение не удалось
                var responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException ecx)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine($"Message :{ecx.Message}");
            }
        }
    }
}
