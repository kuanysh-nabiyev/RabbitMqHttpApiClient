using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.ChannelModel
{
    public class ConnectionDetails
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("peer_port")]
        public int PeerPort { get; set; }

        [JsonProperty("peer_host")]
        public string PeerHost { get; set; }
    }
}
