using Newtonsoft.Json;
using RabbitMqHttpApiClient.Models.Common;

namespace RabbitMqHttpApiClient.Models.DefinitionModel
{
    public class Binding
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("vhost")]
        public string Vhost { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("destination_type")]
        public string DestinationType { get; set; }

        [JsonProperty("routing_key")]
        public string RoutingKey { get; set; }

        [JsonProperty("arguments")]
        public Arguments Arguments { get; set; }

        [JsonProperty("properties_key")]
        public string PropertiesKey { get; set; }
    }

    public enum ExchangeBindingType
    {
        Source,
        Destination
    }
}
