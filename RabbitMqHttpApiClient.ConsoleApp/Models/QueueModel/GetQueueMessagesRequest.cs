using RabbitMqHttpApiClient.ConsoleApp.Models.ExchangeModel.PublishMessageModel;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.QueueModel
{
    public class GetQueueMessagesRequest 
    {
        public int count { get; set; }
        public bool requeue { get; set; }
        public string encoding { get; set; }
    }
}