using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.ClusterModel
{
    public class Cluster
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}