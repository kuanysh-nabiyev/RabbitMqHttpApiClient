using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.Common
{
    public class MessageStats
    {
        [JsonProperty("publish")]
        public int Publish { get; set; }

        [JsonProperty("publish_details")]
        public RateDetails PublishDetails { get; set; }

        [JsonProperty("publish_in")]
        public int PublishIn { get; set; }

        [JsonProperty("publish_in_details")]
        public RateDetails PublishInDetails { get; set; }

        [JsonProperty("publish_out")]
        public int PublishOut { get; set; }

        [JsonProperty("publish_out_details")]
        public RateDetails PublishOutDetails { get; set; }

        [JsonProperty("ack")]
        public int Ack { get; set; }

        [JsonProperty("ack_details")]
        public RateDetails AckDetails { get; set; }

        [JsonProperty("deliver_get")]
        public int DeliverGet { get; set; }

        [JsonProperty("deliver_get_details")]
        public RateDetails DeliverGetDetails { get; set; }

        [JsonProperty("confirm")]
        public int Confirm { get; set; }

        [JsonProperty("confirm_details")]
        public RateDetails ConfirmDetails { get; set; }

        [JsonProperty("return_unroutable")]
        public int ReturnUnroutable { get; set; }

        [JsonProperty("return_unroutable_details")]
        public RateDetails ReturnUnroutableDetails { get; set; }

        [JsonProperty("redeliver")]
        public int Redeliver { get; set; }

        [JsonProperty("redeliver_details")]
        public RateDetails RedeliverDetails { get; set; }

        [JsonProperty("deliver")]
        public int Deliver { get; set; }

        [JsonProperty("deliver_details")]
        public RateDetails DeliverDetails { get; set; }

        [JsonProperty("deliver_no_ack")]
        public int DeliverNoAck { get; set; }

        [JsonProperty("deliver_no_ack_details")]
        public RateDetails DeliverNoAckDetails { get; set; }

        [JsonProperty("get")]
        public int Get { get; set; }

        [JsonProperty("get_details")]
        public RateDetails GetDetails { get; set; }

        [JsonProperty("get_no_ack")]
        public int GetNoAck { get; set; }

        [JsonProperty("get_no_ack_details")]
        public RateDetails GetNoAckDetails { get; set; }
    }
}
