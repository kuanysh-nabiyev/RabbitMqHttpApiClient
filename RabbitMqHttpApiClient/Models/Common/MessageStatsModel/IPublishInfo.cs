using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.Common.MessageStatsModel
{
    public interface IPublishInfo
    {
        [JsonProperty("publish")]
        int Publish { get; set; }

        [JsonProperty("publish_details")]
        RateDetails PublishDetails { get; set; }

        [JsonProperty("publish_in")]
        int PublishIn { get; set; }

        [JsonProperty("publish_in_details")]
        RateDetails PublishInDetails { get; set; }

        [JsonProperty("publish_out")]
        int PublishOut { get; set; }

        [JsonProperty("publish_out_details")]
        RateDetails PublishOutDetails { get; set; }
    }
}