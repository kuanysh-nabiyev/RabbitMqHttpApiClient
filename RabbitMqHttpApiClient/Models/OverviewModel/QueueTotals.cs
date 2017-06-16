using Newtonsoft.Json;
using RabbitMqHttpApiClient.Models.Common;

namespace RabbitMqHttpApiClient.Models.OverviewModel
{
    public class QueueTotals
    {
        [JsonProperty("messages")]
        public long Messages { get; set; }

        [JsonProperty("messages_details")]
        public RateDetails MessagesDetails { get; set; }

        [JsonProperty("messages_ready")]
        public long MessagesReady { get; set; }

        [JsonProperty("messages_ready_details")]
        public RateDetails MessagesReadyDetails { get; set; }

        [JsonProperty("messages_unacknowledged")]
        public long MessagesUnacknowledged { get; set; }

        [JsonProperty("messages_unacknowledged_details")]
        public RateDetails MessagesUnacknowledgedDetails { get; set; }
    }
}