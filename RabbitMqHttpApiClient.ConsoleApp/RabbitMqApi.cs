using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models;
using RabbitMqHttpApiClient.ConsoleApp.Models.OverviewModel;
using RabbitMqHttpApiClient.ConsoleApp.Models.PublishMessage;

namespace RabbitMqHttpApiClient.ConsoleApp
{
    public class RabbitMqApi
    {
        private static readonly HttpClient Http;

        static RabbitMqApi()
        {
            Http = new HttpClient { Timeout = TimeSpan.FromMinutes(2) };
        }

        public RabbitMqApi(string rabbitMqUrl, string username, string password)
        {
            var basicAuthHeader = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));

            Http.BaseAddress = new Uri(rabbitMqUrl);
            Http.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", basicAuthHeader);
        }

        public async Task<T> DoCall<T>(string path, HttpMethod method, dynamic body = null)
        {
            HttpResponseMessage response;
            if (method == HttpMethod.Get)
            {
                response = await Http.GetAsync(path);
            } 
            else if (method == HttpMethod.Post)
            {
                string messageBodyContent = JsonConvert.SerializeObject(body);
                response = await Http.PostAsync(path, new StringContent(messageBodyContent));
            }
            else
            {
                throw new Exception("method not implemented");
            }

            string result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(result);
            }
            else
            {
                throw new HttpRequestException(result);
            }
        }

        /// <summary>
        /// Various random bits of information that describe the whole system.
        /// </summary>
        public async Task<Overview> GetOverview()
        {
            return await DoCall<Overview>("/api/overview", HttpMethod.Get);
        }

        public async Task<IEnumerable<MessageQueue>> GetQueues()
        {
            return await DoCall<IEnumerable<MessageQueue>>("/api/queues", HttpMethod.Get);
        }

        public async Task<PublishMessageResponse> PublishMessage(
            string virtualHost, string exchangeName, string routingKey,
            dynamic payload, string payloadEncoding = "string", Properties properties = null)
        {
            if (virtualHost == "/") virtualHost = "%2F";
            if (exchangeName == String.Empty) exchangeName = routingKey;

            var request = new PublishMessageRequest
            {
                payload = JsonConvert.SerializeObject(payload),
                routing_key = routingKey,
                properties = new Properties(),
                payload_encoding = payloadEncoding
            };

            return await DoCall<PublishMessageResponse>(
                $"/api/exchanges/{virtualHost}/{exchangeName}/publish", HttpMethod.Post, request);
        }
    }
}