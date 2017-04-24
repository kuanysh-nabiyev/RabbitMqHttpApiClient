using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.ConsumerModel
{
    public class Queue
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("vhost")]
        public string Vhost { get; set; }
    }

}
