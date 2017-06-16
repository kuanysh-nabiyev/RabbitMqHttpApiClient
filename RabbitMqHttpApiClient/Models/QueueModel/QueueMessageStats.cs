using RabbitMqHttpApiClient.Models.Common;
using RabbitMqHttpApiClient.Models.Common.MessageStatsModel;

namespace RabbitMqHttpApiClient.Models.QueueModel
{
    public class QueueMessageStats : MessageStats, IDiskInfo
    {
        public long DiskReads { get; set; }
        public RateDetails DiskReadsDetails { get; set; }

        public long DiskWrites { get; set; }
        public RateDetails DiskWritesDetails { get; set; }
    }
}