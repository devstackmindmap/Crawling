using CrawlingInterfaces;
using System.Net;

namespace CrawImplementations
{
    public class Crawling : ICrawling
    {
        public void Craw(string url)
        {
            // Create a new HttpClient
            HttpClient client = new HttpClient();

            // Make a request to the URL
            HttpResponseMessage response = client.GetAsync(url).Result;

            // Check the status code
            if (response.IsSuccessStatusCode)
            {
                // Read the response
                string responseString = response.Content.ReadAsStringAsync().Result;

                // Do something with the response
                Console.WriteLine(responseString);
            }
            else
            {
                Console.WriteLine("Request failed");
            }
        }
    }
}