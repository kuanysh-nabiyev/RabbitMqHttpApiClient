namespace RabbitMqHttpApiClient.ConsoleApp.Models.ExchangeModel.PublishMessageModel
{
    public class PublishMessageRequest
    {
        public string routing_key { get; set; }
        public dynamic payload { get; set; }

        public Properties properties { get; set; }
        public string payload_encoding { get; set; }
    }
}