using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.OverviewModel
{
    public class Listener
    {
        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }
    }
}