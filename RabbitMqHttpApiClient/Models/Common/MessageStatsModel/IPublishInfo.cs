using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.Common.MessageStatsModel
{
    public interface IPublishInfo
    {
        [JsonProperty("publish")]
        long Publish { get; set; }

        [JsonProperty("publish_details")]
        RateDetails PublishDetails { get; set; }

        [JsonProperty("publish_in")]
        long PublishIn { get; set; }

        [JsonProperty("publish_in_details")]
        RateDetails PublishInDetails { get; set; }

        [JsonProperty("publish_out")]
        long PublishOut { get; set; }

        [JsonProperty("publish_out_details")]
        RateDetails PublishOutDetails { get; set; }
    }
}