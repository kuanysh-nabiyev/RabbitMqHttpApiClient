using RabbitMqHttpApiClient.Models.Common;
using RabbitMqHttpApiClient.Models.Common.MessageStatsModel;

namespace RabbitMqHttpApiClient.Models.ExchangeModel
{
    public class MessageStats 
        : IPublishInfo, IAck, IDeliverGet, IConfirm, IReturnUnroutable, IRedeliver
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
    }
}
