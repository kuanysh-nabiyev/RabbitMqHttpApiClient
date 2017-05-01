# RabbitMqHttpApiClient
C# wrapper for RabbitMQ HTTP Management API 
===========================================

Examples:
```
[HttpGet("/api/queues/{name}")]
public async Task<dynamic> GetQueueByName(string name)
{
    var queue = await _rabbitMqApi.GetQueueByVhostAndName("/", name);
    var messages = await _rabbitMqApi.GetQueueMessages("/", name);

    return new {
        Name = queue.Name,
        Messages = messages.Select(item => new 
        {
            Payload = item.Payload,
            PayloadBytes = item.PayloadBytes     
        })
    };
}
```

Other methods:
```
var rabbitMqApi = new RabbitMqApi("http://localhost:15672", "guest", "guest");

var result = rabbitMqApi.GetQueues().Result;
var result = rabbitMqApi.GetQueuesByVhost("/").Result;
var result = rabbitMqApi.GetQueueByVhostAndName("/", "queueName").Result;
var result = rabbitMqApi.PublishMessage("/", "", "queueName", new RequestApprovedEvent { RequestId = 12345}).Result;
var result = rabbitMqApi.GetOverview().Result;
var result = rabbitMqApi.GetNodes().Result;
var result = rabbitMqApi.GetExtensions().Result;
var result = rabbitMqApi.GetDefinitions().Result;
var result = rabbitMqApi.GetDefinitionByVhost("/").Result;
var result = rabbitMqApi.GetConnections().Result;
var result = rabbitMqApi.GetConnectionsByVhost("/").Result;
var result = rabbitMqApi.GetConnection("192.168.4.10:53094 -> 192.168.4.135:5672").Result;
var result = rabbitMqApi.GetChannel("192.168.4.10:53094 -> 192.168.4.135:5672 (1)").Result;
var result = rabbitMqApi.GetChannels().Result;
var result = rabbitMqApi.GetChannelsByVhost("/").Result;
var result = rabbitMqApi.GetChannelsByConnection("192.168.4.10:53094 -> 192.168.4.135:5672").Result;
var result = rabbitMqApi.GetConsumers().Result;
var result = rabbitMqApi.GetConsumersByVhost("/").Result;
var result = rabbitMqApi.GetExchanges().Result;
var result = rabbitMqApi.GetExchangesByVhost("/").Result;
var result = rabbitMqApi.GetExchangeByVhostAndName("/", "exchangeName").Result;
var result = rabbitMqApi.GetBindings().Result;
var result = rabbitMqApi.GetBindingsByVhost("/").Result;
var result = rabbitMqApi.GetBindingsByVhostAndQueue("/", "queueName").Result;
var result = rabbitMqApi.GetBindingsByVhostAndExchange("/", "queueName", ExchangeBindingType.Destination).Result;
var result = rabbitMqApi.GetQueueMessages("/", "queueName", 2).Result;
var result = rabbitMqApi.DeleteAllQueueMessages("/", "queueName").Result;
var result = rabbitMqApi.GetClusterName().Result;
```
