using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.Common.MessageStatsModel
{
    public interface IDiskInfo
    {
        [JsonProperty("disk_reads")]
        int DiskReads { get; set; }

        [JsonProperty("disk_reads_details")]
        RateDetails DiskReadsDetails { get; set; }

        [JsonProperty("disk_writes")]
        int DiskWrites { get; set; }

        [JsonProperty("disk_writes_details")]
        RateDetails DiskWritesDetails { get; set; }
    }
}