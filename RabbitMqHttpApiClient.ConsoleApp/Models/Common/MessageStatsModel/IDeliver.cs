using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.Common.MessageStatsModel
{
    public interface IDeliver
    {
        [JsonProperty("deliver")]
        int Deliver { get; set; }

        [JsonProperty("deliver_details")]
        RateDetails DeliverDetails { get; set; }
    }
}