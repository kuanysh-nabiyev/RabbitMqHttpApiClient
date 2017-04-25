using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.Common.MessageStatsModel
{
    public interface IGetNoAck
    {
        [JsonProperty("get_no_ack")]
        int GetNoAck { get; set; }

        [JsonProperty("get_no_ack_details")]
        RateDetails GetNoAckDetails { get; set; }
    }
}