using RabbitMqHttpApiClient.API;

namespace RabbitMqHttpApiClient.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rabbitMqApi = new RabbitMqApi("http://localhost:15672", "guest", "guest");

            //var queues = rabbitMqApi.GetQueues().Result;
            //            var queues = rabbitMqApi.GetQueuesByVhost("/").Result;
            //            foreach (var messageQueue in queues)
            //            {
            //                Console.WriteLine($"{messageQueue.Name}");
            //            }
            //var result = rabbitMqApi.GetQueueByVhostAndName("/", "isez").Result;

            //var result = rabbitMqApi.PublishMessage("/", "", "isez", new RequestApprovedEvent { RequestId = 12345}).Result;
            //var overview = rabbitMqApi.GetOverview().Result;
            //var nodes = rabbitMqApi.GetNodes().Result;
            //var node = rabbitMqApi.GetNode("rabbit@KUANYSH-PC", true, true).Result;
            //var extensions = rabbitMqApi.GetExtensions().Result;
            //var definitions = rabbitMqApi.GetDefinitions().Result;
            //var result = rabbitMqApi.GetDefinitionByVhost("/").Result;
            //var connections = rabbitMqApi.GetConnections().Result;
            //var result = rabbitMqApi.GetConnectionsByVhost("/").Result;
            //var result = rabbitMqApi.GetConnection("192.168.4.10:53094 -> 192.168.4.135:5672").Result;
            //var result = rabbitMqApi.GetChannel("192.168.4.10:53094 -> 192.168.4.135:5672 (1)").Result;
            //var result = rabbitMqApi.GetChannels().Result;
            //var result = rabbitMqApi.GetChannelsByVhost("/").Result;
            //var result = rabbitMqApi.GetChannelsByConnection("192.168.4.10:53094 -> 192.168.4.135:5672").Result;
            //var result = rabbitMqApi.GetConsumers().Result;
            //var result = rabbitMqApi.GetConsumersByVhost("/").Result;
            //var result = rabbitMqApi.GetExchanges().Result;
            //var result = rabbitMqApi.GetExchangesByVhost("/").Result;
            //var result = rabbitMqApi.GetExchangeByVhostAndName("/", "PKO.BusConfiguration.Events:IRequestApprovedEvent").Result;
            //var result = rabbitMqApi.GetBindings().Result;
            //var result = rabbitMqApi.GetBindingsByVhost("/").Result;
            //var result = rabbitMqApi.GetBindingsByVhostAndQueue("/", "isez").Result;
            //var result = rabbitMqApi.GetBindingsByVhostAndExchange("/", "isez", ExchangeBindingType.Destination).Result;
            //var result = rabbitMqApi.GetQueueMessages("/", "isez", 2).Result;
            //var result = rabbitMqApi.DeleteAllQueueMessages("/", "acts.executer.service_error").Result;
            //var result = rabbitMqApi.GetClusterName().Result;
            //var result = rabbitMqApi.GetVirtualHostByName("/").Result;
            //var result = rabbitMqApi.GetUsers().Result;
            //var result = rabbitMqApi.GetUserByName("guest").Result;
            //var result = rabbitMqApi.GetUserPermissions("guest").Result;
            var result = rabbitMqApi.GetAuthenticatedUserInfo().Result;
        }

        private class RequestApprovedEvent
        {
            public int RequestId { get; set; }
        }
    }
}