using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.Common
{
    public class ExchangeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}