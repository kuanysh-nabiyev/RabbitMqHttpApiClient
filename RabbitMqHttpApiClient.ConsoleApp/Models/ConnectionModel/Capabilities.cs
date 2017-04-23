using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.ConnectionModel
{
    public class Capabilities
    {
        [JsonProperty("publisher_confirms")]
        public bool PublisherConfirms { get; set; }

        [JsonProperty("exchange_exchange_bindings")]
        public bool ExchangeExchangeBindings { get; set; }

        [JsonProperty("basic.nack")]
        public bool BasicNack { get; set; }

        [JsonProperty("consumer_cancel_notify")]
        public bool ConsumerCancelNotify { get; set; }

        [JsonProperty("connection.blocked")]
        public bool ConnectionBlocked { get; set; }

        [JsonProperty("authentication_failure_close")]
        public bool AuthenticationFailureClose { get; set; }
    }
}
