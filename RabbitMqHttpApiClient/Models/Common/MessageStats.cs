using RabbitMqHttpApiClient.Models.Common.MessageStatsModel;

namespace RabbitMqHttpApiClient.Models.Common
{
    public class MessageStats 
        : IPublishInfo, IAck, IDeliverGet, IConfirm, IReturnUnroutable, 
          IRedeliver, IDeliver, IDeliverNoAck, IGet, IGetNoAck
    {
        public long Publish { get; set; }
        public RateDetails PublishDetails { get; set; }

        public long PublishIn { get; set; }
        public RateDetails PublishInDetails { get; set; }

        public long PublishOut { get; set; }
        public RateDetails PublishOutDetails { get; set; }

        public long Ack { get; set; }
        public RateDetails AckDetails { get; set; }

        public long DeliverGet { get; set; }
        public RateDetails DeliverGetDetails { get; set; }

        public long Confirm { get; set; }
        public RateDetails ConfirmDetails { get; set; }

        public long ReturnUnroutable { get; set; }
        public RateDetails ReturnUnroutableDetails { get; set; }

        public long Redeliver { get; set; }
        public RateDetails RedeliverDetails { get; set; }

        public long Deliver { get; set; }
        public RateDetails DeliverDetails { get; set; }

        public long DeliverNoAck { get; set; }
        public RateDetails DeliverNoAckDetails { get; set; }

        public long Get { get; set; }
        public RateDetails GetDetails { get; set; }

        public long GetNoAck { get; set; }
        public RateDetails GetNoAckDetails { get; set; }
    }
}
