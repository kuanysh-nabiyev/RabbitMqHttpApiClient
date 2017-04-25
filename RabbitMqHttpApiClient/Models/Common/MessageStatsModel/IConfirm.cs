using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.Common.MessageStatsModel
{
    public interface IConfirm
    {
        [JsonProperty("confirm")]
        int Confirm { get; set; }

        [JsonProperty("confirm_details")]
        RateDetails ConfirmDetails { get; set; }
    }
}