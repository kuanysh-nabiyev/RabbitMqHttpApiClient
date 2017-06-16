using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.Common.MessageStatsModel
{
    public interface IDiskInfo
    {
        [JsonProperty("disk_reads")]
        long DiskReads { get; set; }

        [JsonProperty("disk_reads_details")]
        RateDetails DiskReadsDetails { get; set; }

        [JsonProperty("disk_writes")]
        long DiskWrites { get; set; }

        [JsonProperty("disk_writes_details")]
        RateDetails DiskWritesDetails { get; set; }
    }
}