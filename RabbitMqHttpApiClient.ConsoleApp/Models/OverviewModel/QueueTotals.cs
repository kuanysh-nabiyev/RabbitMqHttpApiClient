namespace RabbitMqHttpApiClient.ConsoleApp.Models.OverviewModel
{
    public class QueueTotals
    {
        public int messages { get; set; }
        public RateDetails messages_details { get; set; }
        public int messages_ready { get; set; }
        public RateDetails messages_ready_details { get; set; }
        public int messages_unacknowledged { get; set; }
        public RateDetails messages_unacknowledged_details { get; set; }
    }
}