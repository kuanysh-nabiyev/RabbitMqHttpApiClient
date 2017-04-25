using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.ExchangeModel.PublishMessageModel
{
    public class PublishMessageResponse
    {
        [JsonProperty("routed")]
        public bool Routed { get; set; }
    }
}