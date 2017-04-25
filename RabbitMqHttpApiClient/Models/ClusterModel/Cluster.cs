using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.ClusterModel
{
    public class Cluster
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}