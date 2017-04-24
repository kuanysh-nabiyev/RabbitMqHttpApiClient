using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.Common.MessageStatsModel
{
    public interface IGet
    {
        [JsonProperty("get")]
        int Get { get; set; }

        [JsonProperty("get_details")]
        RateDetails GetDetails { get; set; }
    }
}