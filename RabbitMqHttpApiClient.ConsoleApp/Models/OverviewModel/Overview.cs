using System.Collections.Generic;
using RabbitMqHttpApiClient.ConsoleApp.Models.Common;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.OverviewModel
{
    public class Overview
    {
        public string management_version { get; set; }
        public string rates_mode { get; set; }
        public IEnumerable<ExchangeType> exchange_types { get; set; }
        public string rabbitmq_version { get; set; }
        public string cluster_name { get; set; }
        public string erlang_version { get; set; }
        public string erlang_full_version { get; set; }
        public MessageStats message_stats { get; set; }
        public QueueTotals queue_totals { get; set; }
        public ObjectTotals object_totals { get; set; }
        public int statistics_db_event_queue { get; set; }
        public string node { get; set; }
        public string statistics_db_node { get; set; }
        public IEnumerable<Listener> listeners { get; set; }
        public IEnumerable<Context> contexts { get; set; }
    }

}