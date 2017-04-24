using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.Common.MessageStatsModel
{
    public interface IAck
    {
        [JsonProperty("ack")]
        int Ack { get; set; }

        [JsonProperty("ack_details")]
        RateDetails AckDetails { get; set; }
    }
}