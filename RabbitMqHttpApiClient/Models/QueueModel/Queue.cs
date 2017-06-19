using Newtonsoft.Json;
using RabbitMqHttpApiClient.Models.Common;

namespace RabbitMqHttpApiClient.Models.QueueModel
{
    public class Queue
    {
        [JsonProperty("memory")]
        public long Memory { get; set; }

        [JsonProperty("message_stats")]
        public QueueMessageStats MessageStats { get; set; }

        [JsonProperty("reductions")]
        public long Reductions { get; set; }

        [JsonProperty("reductions_details")]
        public RateDetails ReductionsDetails { get; set; }

        [JsonProperty("messages")]
        public long Messages { get; set; }

        [JsonProperty("messages_details")]
        public RateDetails MessagesDetails { get; set; }

        [JsonProperty("messages_ready")]
        public long MessagesReady { get; set; }

        [JsonProperty("messages_ready_details")]
        public RateDetails MessagesReadyDetails { get; set; }

        [JsonProperty("messages_unacknowledged")]
        public long MessagesUnacknowledged { get; set; }

        [JsonProperty("messages_unacknowledged_details")]
        public RateDetails MessagesUnacknowledgedDetails { get; set; }

        [JsonProperty("idle_since")]
        public string IdleSince { get; set; }

        [JsonProperty("consumer_utilisation")]
        public double? ConsumerUtilisation { get; set; }

        [JsonProperty("policy")]
        public string Policy { get; set; }

        [JsonProperty("exclusive_consumer_tag")]
        public string ExclusiveConsumerTag { get; set; }

        [JsonProperty("consumers")]
        public int Consumers { get; set; }

        [JsonProperty("recoverable_slaves")]
        public object RecoverableSlaves { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("garbage_collection")]
        public GarbageCollection GarbageCollection { get; set; }

        [JsonProperty("messages_ram")]
        public long MessagesRam { get; set; }

        [JsonProperty("messages_ready_ram")]
        public long MessagesReadyRam { get; set; }

        [JsonProperty("messages_unacknowledged_ram")]
        public long MessagesUnacknowledgedRam { get; set; }

        [JsonProperty("messages_persistent")]
        public long MessagesPersistent { get; set; }

        [JsonProperty("message_bytes")]
        public long MessageBytes { get; set; }

        [JsonProperty("message_bytes_ready")]
        public long MessageBytesReady { get; set; }

        [JsonProperty("message_bytes_unacknowledged")]
        public long MessageBytesUnacknowledged { get; set; }

        [JsonProperty("message_bytes_ram")]
        public long MessageBytesRam { get; set; }

        [JsonProperty("message_bytes_persistent")]
        public long MessageBytesPersistent { get; set; }

        [JsonProperty("head_message_timestamp")]
        public object HeadMessageTimestamp { get; set; }

        [JsonProperty("disk_reads")]
        public long DiskReads { get; set; }

        [JsonProperty("disk_writes")]
        public long DiskWrites { get; set; }

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