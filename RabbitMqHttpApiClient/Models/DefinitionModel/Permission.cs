using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.DefinitionModel
{
    public class Permission
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("vhost")]
        public string Vhost { get; set; }

        [JsonProperty("configure")]
        public string Configure { get; set; }

        [JsonProperty("write")]
        public string Write { get; set; }

        [JsonProperty("read")]
        public string Read { get; set; }
    }

}
