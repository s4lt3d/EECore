using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;


namespace EECore
{
    public class WebRequests
    {
        public string baseUrl = "http://qz.earthempires.com/api";
        public string userName = "salted";
        public string apiKey = "49ee125ad5e9a3b81dfb771ac0d3d2fb";

        public Task<HttpResponseMessage> HttpClient { get; private set; }
        HttpClient client;

        public WebRequests()
        {
            client = new System.Net.Http.HttpClient();
        }

        public async Task<string> Request(string body)
        {
            HttpRequestMessage _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new Uri(baseUrl);
            _httpRequest.Headers.Add("api_payload", body);

            _httpResponse = await client.SendAsync(_httpRequest);
            string b = await _httpResponse.Content.ReadAsStringAsync();
            Console.WriteLine(b);

            return "";
        }

    }
}
