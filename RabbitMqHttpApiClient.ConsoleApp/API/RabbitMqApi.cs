using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models.ClusterModel;
using RabbitMqHttpApiClient.ConsoleApp.Models.DefinitionModel;
using RabbitMqHttpApiClient.ConsoleApp.Models.ExtensionModel;
using RabbitMqHttpApiClient.ConsoleApp.Models.OverviewModel;
using RabbitMqHttpApiClient.ConsoleApp.Utils;
using Queue = RabbitMqHttpApiClient.ConsoleApp.Models.QueueModel.Queue;

namespace RabbitMqHttpApiClient.ConsoleApp.API
{
    public partial class RabbitMqApi
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

        public async Task<T> DoGetCall<T>(string path)
        {
            return await DoCall<T>(path, HttpMethod.Get);
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
        /// A list of all queues.
        /// </summary>
        public async Task<IEnumerable<Queue>> GetQueues()
        {
            return await DoGetCall<IEnumerable<Queue>>("/api/queues");
        }
    }
}