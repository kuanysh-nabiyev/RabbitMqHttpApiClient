using System.Collections.Generic;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.QueueModel
{
    public class BackingQueueStatus
    {
        public string mode { get; set; }
        public int q1 { get; set; }
        public int q2 { get; set; }
        public List<object> delta { get; set; }
        public int q3 { get; set; }
        public int q4 { get; set; }
        public int len { get; set; }
        public string target_ram_count { get; set; }
        public int next_seq_id { get; set; }
        public double avg_ingress_rate { get; set; }
        public double avg_egress_rate { get; set; }
        public double avg_ack_ingress_rate { get; set; }
        public double avg_ack_egress_rate { get; set; }
    }
}