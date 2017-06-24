using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.SystemInfoModel
{
    public class ManagementPluginExtension
    {
        [JsonProperty("javascript")]
        public string Javascript { get; set; }
    }
}