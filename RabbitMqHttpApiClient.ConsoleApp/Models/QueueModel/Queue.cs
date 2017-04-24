using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models.Common;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.QueueModel
{
    public class Queue
    {
        [JsonProperty("memory")]
        public int Memory { get; set; }

        [JsonProperty("message_stats")]
        public QueueMessageStats MessageStats { get; set; }

        [JsonProperty("reductions")]
        public int Reductions { get; set; }

        [JsonProperty("reductions_details")]
        public RateDetails ReductionsDetails { get; set; }

        [JsonProperty("messages")]
        public int Messages { get; set; }

        [JsonProperty("messages_details")]
        public RateDetails MessagesDetails { get; set; }

        [JsonProperty("messages_ready")]
        public int MessagesReady { get; set; }

        [JsonProperty("messages_ready_details")]
        public RateDetails MessagesReadyDetails { get; set; }

        [JsonProperty("messages_unacknowledged")]
        public int MessagesUnacknowledged { get; set; }

        [JsonProperty("messages_unacknowledged_details")]
        public RateDetails MessagesUnacknowledgedDetails { get; set; }

        [JsonProperty("idle_since")]
        public string IdleSince { get; set; }

        [JsonProperty("consumer_utilisation")]
        public object ConsumerUtilisation { get; set; }

        [JsonProperty("policy")]
        public object Policy { get; set; }

        [JsonProperty("exclusive_consumer_tag")]
        public object ExclusiveConsumerTag { get; set; }

        [JsonProperty("consumers")]
        public int Consumers { get; set; }

        [JsonProperty("recoverable_slaves")]
        public object RecoverableSlaves { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("garbage_collection")]
        public GarbageCollection GarbageCollection { get; set; }

        [JsonProperty("messages_ram")]
        public int MessagesRam { get; set; }

        [JsonProperty("messages_ready_ram")]
        public int MessagesReadyRam { get; set; }

        [JsonProperty("messages_unacknowledged_ram")]
        public int MessagesUnacknowledgedRam { get; set; }

        [JsonProperty("messages_persistent")]
        public int MessagesPersistent { get; set; }

        [JsonProperty("message_bytes")]
        public int MessageBytes { get; set; }

        [JsonProperty("message_bytes_ready")]
        public int MessageBytesReady { get; set; }

        [JsonProperty("message_bytes_unacknowledged")]
        public int MessageBytesUnacknowledged { get; set; }

        [JsonProperty("message_bytes_ram")]
        public int MessageBytesRam { get; set; }

        [JsonProperty("message_bytes_persistent")]
        public int MessageBytesPersistent { get; set; }

        [JsonProperty("head_message_timestamp")]
        public object HeadMessageTimestamp { get; set; }

        [JsonProperty("disk_reads")]
        public int DiskReads { get; set; }

        [JsonProperty("disk_writes")]
        public int DiskWrites { get; set; }

        [JsonProperty("backing_queue_status")]
        public BackingQueueStatus BackingQueueStatus { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("arguments")]
        public Arguments Arguments { get; set; }

        [JsonProperty("exclusive")]
        public bool Exclusive { get; set; }

        [JsonProperty("auto_delete")]
        public bool AutoDelete { get; set; }

        [JsonProperty("durable")]
        public bool Durable { get; set; }

        [JsonProperty("vhost")]
        public string Vhost { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}