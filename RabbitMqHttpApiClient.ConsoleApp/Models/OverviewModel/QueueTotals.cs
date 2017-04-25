using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models.Common;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.OverviewModel
{
    public class QueueTotals
    {
        [JsonProperty("messages")]
        public int Messages { get; set; }

        [JsonProperty("messages_details")]
        public RateDetails MessagesDetails { get; set; }

        [JsonProperty("messages_ready")]
        public int MessagesReady { get; set; }

        [JsonProperty("messages_ready_details")]
        public RateDetails MessagesReadyDetails { get; set; }

        [JsonProperty("messages_unacknowledged")]
        public int MessagesUnacknowledged { get; set; }

        [JsonProperty("messages_unacknowledged_details")]
        public RateDetails MessagesUnacknowledgedDetails { get; set; }
    }
}