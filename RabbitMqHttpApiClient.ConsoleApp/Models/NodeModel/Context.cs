using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.NodeModel
{
    public class Context
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("port")]
        public string Port { get; set; }
    }
}