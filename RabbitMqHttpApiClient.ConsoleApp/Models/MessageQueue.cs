namespace RabbitMqHttpApiClient.ConsoleApp.Models
{
    public class MessageQueue
    {
        public string Name { get; set; }
        public string Vhost { get; set; }
        public int Messages { get; set; }
        public int Messages_Ready { get; set; }
        public int Messages_Unacknowledged { get; set; }
        public bool Durable { get; set; }
        public bool Auto_Delete { get; set; }
        public bool Exclusive { get; set; }
        public int Consumers { get; set; }
        public string Node { get; set; }
    }
}