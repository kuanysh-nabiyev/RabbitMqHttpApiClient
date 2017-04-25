using Newtonsoft.Json;
using RabbitMqHttpApiClient.Models.Common;

namespace RabbitMqHttpApiClient.Models.OverviewModel
{
    public class Overview
    {
        [JsonProperty("management_version")]
        public string ManagementVersion { get; set; }

        [JsonProperty("rates_mode")]
        public string RatesMode { get; set; }

        [JsonProperty("exchange_types")]
        public ExchangeType[] ExchangeTypes { get; set; }

        [JsonProperty("rabbitmq_version")]
        public string RabbitmqVersion { get; set; }

        [JsonProperty("cluster_name")]
        public string ClusterName { get; set; }

        [JsonProperty("erlang_version")]
        public string ErlangVersion { get; set; }

        [JsonProperty("erlang_full_version")]
        public string ErlangFullVersion { get; set; }

        [JsonProperty("message_stats")]
        public MessageStats MessageStats { get; set; }

        [JsonProperty("queue_totals")]
        public QueueTotals QueueTotals { get; set; }

        [JsonProperty("object_totals")]
        public ObjectTotals ObjectTotals { get; set; }

        [JsonProperty("statistics_db_event_queue")]
        public int StatisticsDbEventQueue { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("statistics_db_node")]
        public string StatisticsDbNode { get; set; }

        [JsonProperty("listeners")]
        public Listener[] Listeners { get; set; }

        [JsonProperty("contexts")]
        public Context[] Contexts { get; set; }
    }

}