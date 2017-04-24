using System.Collections.Generic;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.ConsoleApp.Models.ExchangeModel;
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
    }
}