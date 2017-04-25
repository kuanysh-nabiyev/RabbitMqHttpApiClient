using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.ExtensionModel
{
    public class ManagementPluginExtension
    {
        [JsonProperty("javascript")]
        public string Javascript { get; set; }
    }
}