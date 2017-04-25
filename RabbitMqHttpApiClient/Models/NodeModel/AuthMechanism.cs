using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.NodeModel
{
    public class AuthMechanism
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}