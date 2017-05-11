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
    string virtualHost = "/";
    var queue = await _rabbitMqApi.GetQueueByVhostAndName(virtualHost, name);
    var messages = await _rabbitMqApi.GetQueueMessages(virtualHost, name);

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
rabbitMqApi.GetQueuesByVhost("virtualHost");
rabbitMqApi.GetQueueByVhostAndName("virtualHost", "queueName");
rabbitMqApi.PublishMessage("virtualHost", "exchangeName", "queueName", objectToPublish);
rabbitMqApi.GetOverview();
rabbitMqApi.GetNodes();
rabbitMqApi.GetNode("nodeName", withMemory:true, withBinary:true)
rabbitMqApi.GetExtensions();
rabbitMqApi.GetDefinitions();
rabbitMqApi.GetDefinitionByVhost("virtualHost");
rabbitMqApi.GetConnections();
rabbitMqApi.GetConnectionsByVhost("virtualHost");
rabbitMqApi.GetConnection("connectionname");
rabbitMqApi.GetChannel("channelname");
rabbitMqApi.GetChannels();
rabbitMqApi.GetChannelsByVhost("virtualHost");
rabbitMqApi.GetChannelsByConnection("connectionname");
rabbitMqApi.GetConsumers();
rabbitMqApi.GetConsumersByVhost("virtualHost");
rabbitMqApi.GetExchanges();
rabbitMqApi.GetExchangesByVhost("virtualHost");
rabbitMqApi.GetExchangeByVhostAndName("virtualHost", "exchangeName");
rabbitMqApi.GetBindings();
rabbitMqApi.GetBindingsByVhost("virtualHost");
rabbitMqApi.GetBindingsByVhostAndQueue("virtualHost", "queueName");
rabbitMqApi.GetBindingsByVhostAndExchange("virtualHost", "queueName", ExchangeBindingType.Destination);
rabbitMqApi.GetQueueMessages("virtualHost", "queueName", quantityOfMessagesToGet);
rabbitMqApi.DeleteAllQueueMessages("virtualHost", "queueName");
rabbitMqApi.GetClusterName();
```
