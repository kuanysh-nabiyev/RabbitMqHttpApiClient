# RabbitMqHttpApiClient
C# wrapper for RabbitMQ HTTP Management API 
===========================================

Installation:
```
Install-Package RabbitMqHttpApiClient
```

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

rabbitMqApi.GetQueues();
rabbitMqApi.GetQueuesByVhost("/");
rabbitMqApi.GetQueueByVhostAndName("/", "queueName");
rabbitMqApi.PublishMessage("/", "", "queueName", new RequestApprovedEvent { RequestId = 12345});
rabbitMqApi.GetOverview();
rabbitMqApi.GetNodes();
rabbitMqApi.GetExtensions();
rabbitMqApi.GetDefinitions();
rabbitMqApi.GetDefinitionByVhost("/");
rabbitMqApi.GetConnections();
rabbitMqApi.GetConnectionsByVhost("/");
rabbitMqApi.GetConnection("192.168.4.10:53094 -> 192.168.4.135:5672");
rabbitMqApi.GetChannel("192.168.4.10:53094 -> 192.168.4.135:5672 (1)");
rabbitMqApi.GetChannels();
rabbitMqApi.GetChannelsByVhost("/");
rabbitMqApi.GetChannelsByConnection("192.168.4.10:53094 -> 192.168.4.135:5672");
rabbitMqApi.GetConsumers();
rabbitMqApi.GetConsumersByVhost("/");
rabbitMqApi.GetExchanges();
rabbitMqApi.GetExchangesByVhost("/");
rabbitMqApi.GetExchangeByVhostAndName("/", "exchangeName");
rabbitMqApi.GetBindings();
rabbitMqApi.GetBindingsByVhost("/");
rabbitMqApi.GetBindingsByVhostAndQueue("/", "queueName");
rabbitMqApi.GetBindingsByVhostAndExchange("/", "queueName", ExchangeBindingType.Destination);
rabbitMqApi.GetQueueMessages("/", "queueName", 2);
rabbitMqApi.DeleteAllQueueMessages("/", "queueName");
rabbitMqApi.GetClusterName();
```
