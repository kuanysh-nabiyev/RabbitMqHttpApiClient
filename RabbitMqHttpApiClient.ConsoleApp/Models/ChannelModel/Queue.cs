using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.ChannelModel
{
    public class Queue
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("vhost")]
        public string Vhost { get; set; }
    }
}
