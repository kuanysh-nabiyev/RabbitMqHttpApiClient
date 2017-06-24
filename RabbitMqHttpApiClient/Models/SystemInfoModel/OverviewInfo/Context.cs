using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.SystemInfoModel.OverviewInfo
{
    public class Context
    {
        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("port")]
        public string Port { get; set; }
    }
}