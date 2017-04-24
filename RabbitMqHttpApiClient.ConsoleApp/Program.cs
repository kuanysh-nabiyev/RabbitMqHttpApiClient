using System;
using System.Collections.Generic;
using RabbitMqHttpApiClient.ConsoleApp.API;
using RabbitMqHttpApiClient.ConsoleApp.Models.QueueModel;

namespace RabbitMqHttpApiClient.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rabbitMqApi = new RabbitMqApi("http://localhost:15672", "guest", "guest");
            //var rabbitMqApi = new RabbitMqApi("http://192.168.4.135:15672", "admin", "admin123!");

            IEnumerable<Queue> queues = rabbitMqApi.GetQueues().Result;
            foreach (var messageQueue in queues)
            {
                Console.WriteLine($"{messageQueue.Name}");
            }

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
            //var result = rabbitMqApi.GetExchangesByVhostAndName("/", "PKO.BusConfiguration.Events:IRequestApprovedEvent").Result;
        }

        private class RequestApprovedEvent
        {
            public int RequestId { get; set; }
        }
    }
}