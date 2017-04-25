using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.ConsumerModel
{
    public class ChannelDetails
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("connection_name")]
        public string ConnectionName { get; set; }

        [JsonProperty("peer_port")]
        public int PeerPort { get; set; }

        [JsonProperty("peer_host")]
        public string PeerHost { get; set; }
    }

}
