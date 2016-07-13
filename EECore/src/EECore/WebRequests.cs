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
        private bool busy = false;
        private string response = "";

        public Task<HttpResponseMessage> HttpClient { get; private set; }
        HttpClient client;

        public WebRequests()
        {
            client = new System.Net.Http.HttpClient();
        }

        public string Request(string body)
        {
            DoRequest(body);
            while (busy == true) ;
            return response;
        }


        public async Task DoRequest(string body)
        {
            busy = true;
            Console.WriteLine(body);
             
            var _httpResponse = await client.PostAsync(baseUrl, new StringContent("api_payload=" + body, System.Text.Encoding.UTF8, "application/x-www-form-urlencoded"));

            string b = await _httpResponse.Content.ReadAsStringAsync();
            Console.WriteLine(b);
            
            response = b;
            busy = false;
        }

    }
}
