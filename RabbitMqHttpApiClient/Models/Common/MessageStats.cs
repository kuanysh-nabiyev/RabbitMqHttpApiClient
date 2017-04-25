using RabbitMqHttpApiClient.Models.Common.MessageStatsModel;

namespace RabbitMqHttpApiClient.Models.Common
{
    public class MessageStats 
        : IPublishInfo, IAck, IDeliverGet, IConfirm, IReturnUnroutable, 
          IRedeliver, IDeliver, IDeliverNoAck, IGet, IGetNoAck
    {
        public int Publish { get; set; }
        public RateDetails PublishDetails { get; set; }

        public int PublishIn { get; set; }
        public RateDetails PublishInDetails { get; set; }

        public int PublishOut { get; set; }
        public RateDetails PublishOutDetails { get; set; }

        public int Ack { get; set; }
        public RateDetails AckDetails { get; set; }

        public int DeliverGet { get; set; }
        public RateDetails DeliverGetDetails { get; set; }

        public int Confirm { get; set; }
        public RateDetails ConfirmDetails { get; set; }

        public int ReturnUnroutable { get; set; }
        public RateDetails ReturnUnroutableDetails { get; set; }

        public int Redeliver { get; set; }
        public RateDetails RedeliverDetails { get; set; }

        public int Deliver { get; set; }
        public RateDetails DeliverDetails { get; set; }

        public int DeliverNoAck { get; set; }
        public RateDetails DeliverNoAckDetails { get; set; }

        public int Get { get; set; }
        public RateDetails GetDetails { get; set; }

        public int GetNoAck { get; set; }
        public RateDetails GetNoAckDetails { get; set; }
    }
}
