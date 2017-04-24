using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models.ExchangeModel;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.DefinitionModel
{
    public class GetDefinitionsResponse
    {
        [JsonProperty("rabbit_version")]
        public string RabbitVersion { get; set; }

        [JsonProperty("users")]
        public User[] Users { get; set; }

        [JsonProperty("vhosts")]
        public VirtualHost[] Vhosts { get; set; }

        [JsonProperty("permissions")]
        public Permission[] Permissions { get; set; }

        [JsonProperty("parameters")]
        public object[] Parameters { get; set; }

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
