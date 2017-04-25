using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models.ExchangeModel.PublishMessageModel;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.QueueModel
{
    public class QueueMessage
    {
        [JsonProperty("payload_bytes")]
        public int PayloadBytes { get; set; }

        [JsonProperty("redelivered")]
        public bool Redelivered { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("routing_key")]
        public string RoutingKey { get; set; }

        [JsonProperty("message_count")]
        public int MessageCount { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("payload_encoding")]
        public string PayloadEncoding { get; set; }
    }
}