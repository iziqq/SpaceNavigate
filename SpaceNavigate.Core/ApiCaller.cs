using System.Net.Http.Headers;
using System.Net.Http;
using SpaceNavigate.Core.Enums;

namespace SpaceNavigate.Core
{
    public static class ApiCaller
    {
        private const string URL = "https://userhw.sandbox.esigno.io";

        public async static Task<HttpResponseMessage> GetHttpResponseAsync(string urlParameters, HttpMethods httpMethod, HttpContent content = null, string token = null)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            if (token != null)
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Add an Accept header for JSON format.
            HttpResponseMessage response = new HttpResponseMessage();
            content.Headers.Clear();
            content.Headers.Add("Content-Type", "application/json");
            switch (httpMethod)
            {
                case HttpMethods.Get:
                    using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, URL + urlParameters))
                    {
                        response = await client.SendAsync(requestMessage);
                    }
                    break;
                case HttpMethods.Post:
                    using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, URL + urlParameters))
                    {
                        requestMessage.Content = content;

                        response = await client.SendAsync(requestMessage);
                    }
                    break;
                case HttpMethods.Put:
                    using (var requestMessage = new HttpRequestMessage(HttpMethod.Put, URL + urlParameters))
                    {
                        requestMessage.Content = content;

                        response = await client.SendAsync(requestMessage);
                    }
                    break;
                case HttpMethods.Delete:
                    using (var requestMessage = new HttpRequestMessage(HttpMethod.Delete, URL + urlParameters))
                    {
                        requestMessage.Content = content;

                        response = await client.SendAsync(requestMessage);
                    }
                    break;
            }

            client.Dispose();
            return response;

        }

    }
}