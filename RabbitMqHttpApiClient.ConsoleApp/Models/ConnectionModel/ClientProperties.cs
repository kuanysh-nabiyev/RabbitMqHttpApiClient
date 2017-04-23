using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.ConnectionModel
{
    public class ClientProperties
    {
        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("information")]
        public string Information { get; set; }

        [JsonProperty("client_api")]
        public string ClientApi { get; set; }

        [JsonProperty("masstransit_version")]
        public string MasstransitVersion { get; set; }

        [JsonProperty("net_version")]
        public string NetVersion { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("connected")]
        public string Connected { get; set; }

        [JsonProperty("process_id")]
        public string ProcessId { get; set; }

        [JsonProperty("process_name")]
        public string ProcessName { get; set; }

        [JsonProperty("assembly")]
        public string Assembly { get; set; }

        [JsonProperty("assembly_version")]
        public string AssemblyVersion { get; set; }

        [JsonProperty("connection_name")]
        public string ConnectionName { get; set; }

        [JsonProperty("capabilities")]
        public Capabilities Capabilities { get; set; }
    }
}
