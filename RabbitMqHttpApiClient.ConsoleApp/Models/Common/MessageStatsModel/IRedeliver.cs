using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.Common.MessageStatsModel
{
    public interface IRedeliver
    {
        [JsonProperty("redeliver")]
        int Redeliver { get; set; }

        [JsonProperty("redeliver_details")]
        RateDetails RedeliverDetails { get; set; }
    }
}