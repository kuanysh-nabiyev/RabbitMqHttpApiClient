using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models.Common;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.QueueModel
{
    public class QueueMessageStats : MessageStats
    {
        [JsonProperty("disk_reads")]
        public int DiskReads { get; set; }

        [JsonProperty("disk_reads_details")]
        public RateDetails DiskReadsDetails { get; set; }

        [JsonProperty("disk_writes")]
        public int DiskWrites { get; set; }

        [JsonProperty("disk_writes_details")]
        public RateDetails DiskWritesDetails { get; set; }
    }
}