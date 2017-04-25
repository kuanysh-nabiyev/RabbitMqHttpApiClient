using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.ExtensionModel
{
    public class ManagementPluginExtension
    {
        [JsonProperty("javascript")]
        public string Javascript { get; set; }
    }
}