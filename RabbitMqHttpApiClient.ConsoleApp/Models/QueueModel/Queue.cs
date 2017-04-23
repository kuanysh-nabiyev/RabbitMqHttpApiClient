using System.Collections.Generic;
using RabbitMqHttpApiClient.ConsoleApp.Models.Common;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.QueueModel
{
    public class Queue
    {
        public string name { get; set; }
        public string vhost { get; set; }
        public bool durable { get; set; }
        public bool auto_delete { get; set; }
        public bool exclusive { get; set; }
        public Arguments arguments { get; set; }
        public string node { get; set; }
        public IEnumerable<object> consumer_details { get; set; }
        public IEnumerable<object> deliveries { get; set; }
        public IEnumerable<object> incoming { get; set; }
        public BackingQueueStatus backing_queue_status { get; set; }
        public int disk_writes { get; set; }
        public int disk_reads { get; set; }
        public object head_message_timestamp { get; set; }
        public int message_bytes_persistent { get; set; }
        public int message_bytes_ram { get; set; }
        public int message_bytes_unacknowledged { get; set; }
        public int message_bytes_ready { get; set; }
        public int message_bytes { get; set; }
        public int messages_persistent { get; set; }
        public int messages_unacknowledged_ram { get; set; }
        public int messages_ready_ram { get; set; }
        public int messages_ram { get; set; }
        public GarbageCollection garbage_collection { get; set; }
        public int reductions { get; set; }
        public string state { get; set; }
        public object recoverable_slaves { get; set; }
        public int consumers { get; set; }
        public object exclusive_consumer_tag { get; set; }
        public object policy { get; set; }
        public object consumer_utilisation { get; set; }
        public string idle_since { get; set; }
        public RateDetails messages_unacknowledged_details { get; set; }
        public int messages_unacknowledged { get; set; }
        public RateDetails messages_ready_details { get; set; }
        public int messages_ready { get; set; }
        public RateDetails messages_details { get; set; }
        public int messages { get; set; }
        public RateDetails reductions_details { get; set; }
        public MessageStats message_stats { get; set; }
        public int memory { get; set; }
    }

}