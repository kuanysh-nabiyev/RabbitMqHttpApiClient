using System.Collections.Generic;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.Models.DefinitionModel;
using RabbitMqHttpApiClient.Utils;

namespace RabbitMqHttpApiClient.API
{
    public partial class RabbitMqApi//.Binding
    {
        /// <summary>
        /// A list of all bindings.
        /// </summary>
        public async Task<IEnumerable<Binding>> GetBindings()
        {
            return await DoGetCall<IEnumerable<Binding>>("api/bindings");
        }

        /// <summary>
        /// A list of all bindings in a given virtual host.
        /// </summary>
        public async Task<IEnumerable<Binding>> GetBindingsByVhost(string virtualHost)
        {
            return await DoGetCall<IEnumerable<Binding>>($"api/bindings/{virtualHost.Encode()}");
        }

        /// <summary>
        /// A list of all bindings on a given queue.
        /// </summary>
        public async Task<IEnumerable<Binding>> GetBindingsByVhostAndQueue(string virtualHost, string queueName)
        {
            return await DoGetCall<IEnumerable<Binding>>($"api/queues/{virtualHost.Encode()}/{queueName}/bindings");
        }

        /// <summary>
        /// A list of all bindings in which a given exchange is the source or destination
        /// </summary>
        public async Task<IEnumerable<Binding>> GetBindingsByVhostAndExchange(
            string virtualHost, string exchangeName, ExchangeBindingType exchangeBindingType)
        {
            string bindingType = exchangeBindingType.ToString("G").ToLower();
            var path = $"api/exchanges/{virtualHost.Encode()}/{exchangeName.Encode()}/bindings/{bindingType}";
            return await DoGetCall<IEnumerable<Binding>>(path);
        }
    }
}