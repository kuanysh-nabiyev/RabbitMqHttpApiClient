using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models.ExchangeModel;
using RabbitMqHttpApiClient.ConsoleApp.Models.ExchangeModel.PublishMessageModel;
using RabbitMqHttpApiClient.ConsoleApp.Utils;

namespace RabbitMqHttpApiClient.ConsoleApp.API
{
    public partial class RabbitMqApi//.Exchange
    {
        /// <summary>
        /// A list of all exchanges.
        /// </summary>
        public async Task<IEnumerable<Exchange>> GetExchanges()
        {
            return await DoGetCall<IEnumerable<Exchange>>("api/exchanges");
        }

        /// <summary>
        /// A list of all exchanges in a given virtual host.
        /// </summary>
        public async Task<IEnumerable<Exchange>> GetExchangesByVhost(string virtualHost)
        {
            return await DoGetCall<IEnumerable<Exchange>>($"api/exchanges/{virtualHost.Encode()}");
        }

        /// <summary>
        /// An individual exchange by virtual host and exchange name 
        /// </summary>
        public async Task<Exchange> GetExchangesByVhostAndName(string virtualHost, string exchangeName)
        {
            return await DoGetCall<Exchange>($"api/exchanges/{virtualHost.Encode()}/{exchangeName.Encode()}");
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
        /// <returns>true if the message was sent to at least one queue.</returns>
        public async Task<bool> PublishMessage(
            string virtualHost, string exchangeName, string routingKey, dynamic payload, 
            PayloadEncoding payloadEncoding = PayloadEncoding.String, Properties properties = null)
        {
            if (exchangeName == String.Empty) exchangeName = routingKey;

            var request = new PublishMessageRequest
            {
                payload = JsonConvert.SerializeObject(payload),
                routing_key = routingKey,
                properties = new Properties(),
                payload_encoding = payloadEncoding.ToString("G").ToLower()
            };

            string path = $"/api/exchanges/{virtualHost.Encode()}/{exchangeName.Encode()}/publish";
            var response = await DoCall<PublishMessageResponse>(path, HttpMethod.Post, request);

            return response.routed;
        }
    }
}