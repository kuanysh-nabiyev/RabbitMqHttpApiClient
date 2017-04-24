using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.DefinitionModel
{
    public class VirtualHost
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
