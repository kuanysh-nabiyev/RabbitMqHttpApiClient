using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.Common.MessageStatsModel
{
    public interface IDeliver
    {
        [JsonProperty("deliver")]
        long Deliver { get; set; }

        [JsonProperty("deliver_details")]
        RateDetails DeliverDetails { get; set; }
    }
}