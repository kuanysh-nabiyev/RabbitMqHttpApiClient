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
IEnumerable<Queue> queues = await rabbitMqApi.GetQueues();

IEnumerable<Queue> GetQueues(); 
IEnumerable<Queue> GetQueuesByVhost("virtualHost");
Queue GetQueueByVhostAndName("virtualHost", "queueName");
IEnumerable<QueueMessage> GetQueueMessages("virtualHost", "queueName", quantityOfMessagesToGet);
bool DeleteAllQueueMessages("virtualHost", "queueName");

IEnumerable<Node> GetNodes();
Node GetNode("nodeName", withMemory:true, withBinary:true)

SystemDefinition GetDefinitions();
VhostDefinition GetDefinitionByVhost("virtualHost");

IEnumerable<Connection> GetConnections();
IEnumerable<Connection> GetConnectionsByVhost("virtualHost");
Connection GetConnection("connectionname");

IEnumerable<Channel> GetChannels();
IEnumerable<Channel> GetChannelsByVhost("virtualHost");
IEnumerable<Channel> GetChannelsByConnection("connectionname");
Channel GetChannel("channelname");

IEnumerable<Consumer> GetConsumers();
IEnumerable<Consumer> GetConsumersByVhost("virtualHost");

IEnumerable<Exchange> GetExchanges();
IEnumerable<Exchange> GetExchangesByVhost("virtualHost");
Exchange GetExchangeByVhostAndName("virtualHost", "exchangeName");
bool PublishMessage("virtualHost", "exchangeName", "queueName", objectToPublish);

IEnumerable<Binding> GetBindings();
IEnumerable<Binding> GetBindingsByVhost("virtualHost");
IEnumerable<Binding> GetBindingsByVhostAndQueue("virtualHost", "queueName");
IEnumerable<Binding> GetBindingsByVhostAndExchange("virtualHost", "queueName", ExchangeBindingType.Destination);

Overview GetOverview();
string GetClusterName();
IEnumerable<ManagementPluginExtension> GetExtensions();
```
