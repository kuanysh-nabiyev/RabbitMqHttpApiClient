using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.Common.MessageStatsModel
{
    public interface IGet
    {
        [JsonProperty("get")]
        long Get { get; set; }

        [JsonProperty("get_details")]
        RateDetails GetDetails { get; set; }
    }
}