using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.Common.MessageStatsModel
{
    public interface IReturnUnroutable
    {
        [JsonProperty("return_unroutable")]
        int ReturnUnroutable { get; set; }

        [JsonProperty("return_unroutable_details")]
        RateDetails ReturnUnroutableDetails { get; set; }
    }
}