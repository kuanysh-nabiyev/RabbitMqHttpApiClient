using System.Collections.Generic;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.ConsoleApp.Models.QueueModel;
using RabbitMqHttpApiClient.ConsoleApp.Utils;

namespace RabbitMqHttpApiClient.ConsoleApp.API
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
    }
}