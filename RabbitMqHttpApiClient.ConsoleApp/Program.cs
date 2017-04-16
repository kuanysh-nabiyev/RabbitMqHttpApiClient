namespace RabbitMqHttpApiClient.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rabbitMqApi = new RabbitMqApi("http://localhost:15672", "guest", "guest");
//            IEnumerable<MessageQueue> queues = rabbitMqApi.GetQueues().Result;
//            foreach (var messageQueue in queues)
//            {
//                Console.WriteLine($"{messageQueue.Name}");
//            }

            //var result = rabbitMqApi.PublishMessage("/", "", "isez", new RequestApprovedEvent { RequestId = 12345}).Result;
            var overview = rabbitMqApi.GetOverview().Result;
        }

        private class RequestApprovedEvent
        {
            public int RequestId { get; set; }
        }
    }
}