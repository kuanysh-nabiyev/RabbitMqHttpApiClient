using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.Models.ExchangeModel.PublishMessageModel;
using RabbitMqHttpApiClient.Models.QueueModel;
using RabbitMqHttpApiClient.Utils;

namespace RabbitMqHttpApiClient.API
{
    public partial class RabbitMqApi//.Queue
    {
        /// <summary>
        /// A list of all queues.
        /// </summary>
        public async Task<IEnumerable<Queue>> GetQueues()
        {
            return await DoGetCall<IEnumerable<Queue>>("/api/queues");
        }

        /// <summary>
        /// A list of all queues in a given virtual host.
        /// </summary>
        public async Task<IEnumerable<Queue>> GetQueuesByVhost(string virtualHost)
        {
            return await DoGetCall<IEnumerable<Queue>>($"/api/queues/{virtualHost.Encode()}");
        }

        /// <summary>
        /// An individual queue by virtual host and queue name.
        /// </summary>
        public async Task<Queue> GetQueueByVhostAndName(string virtualHost, string queueName)
        {
            return await DoGetCall<Queue>($"/api/queues/{virtualHost.Encode()}/{queueName.Encode()}");
        }

        /// <summary>
        /// Get messages from a queue. (This is not an HTTP GET as it will alter the state of the queue.) 
        /// </summary>
        /// <param name="virtualHost"></param>
        /// <param name="queueName"></param>
        /// <param name="count">ols the maximum number of messages to get. You may get fewer messages than this if the queue cannot immediately provide them.</param>
        /// <param name="requeue">determines whether the messages will be removed from the queue. If requeue is true they will be requeued - but their redelivered flag will be set.</param>
        /// <param name="encoding">must be either "auto" (in which case the payload will be returned as a string if it is valid UTF-8, and base64 encoded otherwise), or "base64" (in which case the payload will always be base64 encoded).</param>
        /// <returns></returns>
        public async Task<IEnumerable<QueueMessage>> GetQueueMessages(string virtualHost, string queueName, 
            long count = Int64.MaxValue, bool requeue = true, PayloadEncoding encoding = PayloadEncoding.Auto)
        {
            var request = new GetQueueMessagesRequest
            {
                count = count,
                requeue = requeue,
                encoding = encoding.ToString("G").ToLower(),
            };

            string path = $"/api/queues/{virtualHost.Encode()}/{queueName.Encode()}/get";
            return await DoCall<IEnumerable<QueueMessage>>(path, HttpMethod.Post, request);
        }

        /// <summary>
        /// Purge (delete all messages) of a given queue
        /// </summary>
        /// <returns>true if all messages is deleted</returns>
        public async Task<bool> DeleteAllQueueMessages(string virtualHost, string queueName)
        {
            string path = $"/api/queues/{virtualHost.Encode()}/{queueName.Encode()}/contents";
            return await DoDeleteCall(path);
        }
    }
}