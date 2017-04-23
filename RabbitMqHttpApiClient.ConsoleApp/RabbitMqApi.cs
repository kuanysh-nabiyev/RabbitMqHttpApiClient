using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models;
using RabbitMqHttpApiClient.ConsoleApp.Models.ClusterModel;
using RabbitMqHttpApiClient.ConsoleApp.Models.Common;
using RabbitMqHttpApiClient.ConsoleApp.Models.ConnectionModel;
using RabbitMqHttpApiClient.ConsoleApp.Models.DefinitionModel;
using RabbitMqHttpApiClient.ConsoleApp.Models.ExtensionModel;
using RabbitMqHttpApiClient.ConsoleApp.Models.NodeModel;
using RabbitMqHttpApiClient.ConsoleApp.Models.OverviewModel;
using RabbitMqHttpApiClient.ConsoleApp.Models.PublishMessageModel;
using Queue = RabbitMqHttpApiClient.ConsoleApp.Models.QueueModel.Queue;

namespace RabbitMqHttpApiClient.ConsoleApp
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
        /// Various random bits of information that describe the whole system.
        /// </summary>
        public async Task<Overview> GetOverview()
        {
            return await DoGetCall<Overview>("/api/overview");
        }

        /// <summary>
        /// Name identifying this RabbitMQ cluster.
        /// </summary>
        public async Task<string> GetClusterName()
        {
            var response = await DoGetCall<Cluster>("/api/cluster-name");
            return response.name;
        }

        /// <summary>
        /// A list of extensions to the management plugin.
        /// </summary>
        public async Task<IEnumerable<ManagementPluginExtension>> GetExtensions()
        {
            return await DoGetCall<IEnumerable<ManagementPluginExtension>>("/api/extensions");
        }

        /// <summary>
        /// The server definitions - exchanges, queues, bindings, users, virtual hosts, permissions and parameters. Everything apart from messages.
        /// </summary>
        public async Task<GetDefinitionsResponse> GetDefinitions()
        {
            return await DoGetCall<GetDefinitionsResponse>("/api/definitions");
        }

        /// <summary>
        /// The server definitions for a given virtual host - exchanges, queues, bindings and policies. 
        /// </summary>
        public async Task<GetDefinitionByVhostResponse> GetDefinitionByVhost(string virtualHost)
        {
            if (virtualHost == "/") virtualHost = "%2F";
            return await DoGetCall<GetDefinitionByVhostResponse>($"/api/definitions/{virtualHost}");
        }

        /// <summary>
        /// A list of all queues.
        /// </summary>
        public async Task<IEnumerable<Queue>> GetQueues()
        {
            return await DoGetCall<IEnumerable<Queue>>("/api/queues");
        }

        /// <summary>
        /// Publish a message to a given exchange. 
        /// </summary>
        /// <param name="virtualHost"></param>
        /// <param name="exchangeName"></param>
        /// <param name="routingKey">binding key</param>
        /// <param name="payload">message data</param>
        /// <param name="payloadEncoding">The payload_encoding key should be either "string" (in which case the payload will be taken to be the UTF-8 encoding of the payload field) or "base64" (in which case the payload field is taken to be base64 encoded).</param>
        /// <param name="properties"></param>
        /// <returns>routed will be true if the message was sent to at least one queue.</returns>
        public async Task<bool> PublishMessage(
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

            var response = await DoCall<PublishMessageResponse>(
                $"/api/exchanges/{virtualHost}/{exchangeName}/publish", HttpMethod.Post, request);

            return response.routed;
        }
    }
}