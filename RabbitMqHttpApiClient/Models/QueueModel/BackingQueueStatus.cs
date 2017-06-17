using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.QueueModel
{
    public class BackingQueueStatus
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("q1")]
        public long Q1 { get; set; }

        [JsonProperty("q2")]
        public long Q2 { get; set; }

        [JsonProperty("delta")]
        public object[] Delta { get; set; }

        [JsonProperty("q3")]
        public long Q3 { get; set; }

        [JsonProperty("q4")]
        public long Q4 { get; set; }

        [JsonProperty("len")]
        public long Len { get; set; }

        [JsonProperty("target_ram_count")]
        public string TargetRamCount { get; set; }

        [JsonProperty("next_seq_id")]
        public long NextSeqId { get; set; }

        [JsonProperty("avg_ingress_rate")]
        public double AvgIngressRate { get; set; }

        [JsonProperty("avg_egress_rate")]
        public double AvgEgressRate { get; set; }

        [JsonProperty("avg_ack_ingress_rate")]
        public double AvgAckIngressRate { get; set; }

        [JsonProperty("avg_ack_egress_rate")]
        public double AvgAckEgressRate { get; set; }

    }
}