using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.Common
{
    public class RateDetails
    {
        [JsonProperty("rate")]
        public double Rate { get; set; }
    }
}