using System.Collections.Generic;
using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models.Common;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.ChannelModel
{
    public class Channel
    {
        [JsonProperty("vhost")]
        public string Vhost { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("garbage_collection")]
        public GarbageCollection GarbageCollection { get; set; }

        [JsonProperty("reductions")]
        public int Reductions { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("global_prefetch_count")]
        public int GlobalPrefetchCount { get; set; }

        [JsonProperty("prefetch_count")]
        public int PrefetchCount { get; set; }

        [JsonProperty("acks_uncommitted")]
        public int AcksUncommitted { get; set; }

        [JsonProperty("messages_uncommitted")]
        public int MessagesUncommitted { get; set; }

        [JsonProperty("messages_unconfirmed")]
        public int MessagesUnconfirmed { get; set; }

        [JsonProperty("messages_unacknowledged")]
        public int MessagesUnacknowledged { get; set; }

        [JsonProperty("consumer_count")]
        public int ConsumerCount { get; set; }

        [JsonProperty("confirm")]
        public bool Confirm { get; set; }

        [JsonProperty("transactional")]
        public bool Transactional { get; set; }

        [JsonProperty("idle_since")]
        public string IdleSince { get; set; }

        [JsonProperty("reductions_details")]
        public RateDetails ReductionsDetails { get; set; }

        [JsonProperty("message_stats")]
        public MessageStats MessageStats { get; set; }

        [JsonProperty("consumer_details")]
        public IEnumerable<ConsumerDetail> ConsumerDetails { get; set; }

        [JsonProperty("deliveries")]
        public object[] Deliveries { get; set; }

        [JsonProperty("publishes")]
        public object[] Publishes { get; set; }

        [JsonProperty("connection_details")]
        public ConnectionDetails ConnectionDetails { get; set; }
    }

}
