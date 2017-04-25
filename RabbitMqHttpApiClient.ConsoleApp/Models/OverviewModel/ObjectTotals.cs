using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.OverviewModel
{
    public class ObjectTotals
    {
        [JsonProperty("consumers")]
        public int Consumers { get; set; }

        [JsonProperty("queues")]
        public int Queues { get; set; }

        [JsonProperty("exchanges")]
        public int Exchanges { get; set; }

        [JsonProperty("connections")]
        public int Connections { get; set; }

        [JsonProperty("channels")]
        public int Channels { get; set; }
    }
}