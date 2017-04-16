namespace RabbitMqHttpApiClient.ConsoleApp.Models.OverviewModel
{
    public class ObjectTotals
    {
        public int consumers { get; set; }
        public int queues { get; set; }
        public int exchanges { get; set; }
        public int connections { get; set; }
        public int channels { get; set; }
    }
}