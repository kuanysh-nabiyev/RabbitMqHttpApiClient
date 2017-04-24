using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models.Common;
using RabbitMqHttpApiClient.ConsoleApp.Models.Common.MessageStatsModel;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.QueueModel
{
    public class QueueMessageStats : MessageStats, IDiskInfo
    {
        public int DiskReads { get; set; }
        public RateDetails DiskReadsDetails { get; set; }

        public int DiskWrites { get; set; }
        public RateDetails DiskWritesDetails { get; set; }
    }
}