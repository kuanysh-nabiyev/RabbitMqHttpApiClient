using System.Collections.Generic;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.ConsoleApp.Models.ConsumerModel;
using RabbitMqHttpApiClient.ConsoleApp.Utils;

namespace RabbitMqHttpApiClient.ConsoleApp.API
{
    public partial class RabbitMqApi//.Consumer
    {
        public async Task<IEnumerable<Consumer>> GetConsumers()
        {
            return await DoGetCall<IEnumerable<Consumer>>("api/consumers");
        }

        public async Task<IEnumerable<Consumer>> GetConsumersByVhost(string virtualHost)
        {
            return await DoGetCall<IEnumerable<Consumer>>($"api/consumers/{virtualHost.Encode()}");
        }
    }
}