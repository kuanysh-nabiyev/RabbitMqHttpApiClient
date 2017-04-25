using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.Common
{
    public class RateDetails
    {
        [JsonProperty("rate")]
        public double Rate { get; set; }
    }
}