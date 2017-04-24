using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models.ExchangeModel;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.DefinitionModel
{
    public class GetDefinitionByVhostResponse
    {
        [JsonProperty("rabbit_version")]
        public string RabbitVersion { get; set; }

        [JsonProperty("policies")]
        public object[] Policies { get; set; }

        [JsonProperty("queues")]
        public Queue[] Queues { get; set; }

        [JsonProperty("exchanges")]
        public Exchange[] Exchanges { get; set; }

        [JsonProperty("bindings")]
        public Binding[] Bindings { get; set; }
    }
}