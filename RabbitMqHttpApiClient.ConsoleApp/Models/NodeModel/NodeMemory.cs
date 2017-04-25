using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.NodeModel
{
    public class NodeMemory
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("connection_readers")]
        public int ConnectionReaders { get; set; }

        [JsonProperty("connection_writers")]
        public int ConnectionWriters { get; set; }

        [JsonProperty("connection_channels")]
        public int ConnectionChannels { get; set; }

        [JsonProperty("connection_other")]
        public int ConnectionOther { get; set; }

        [JsonProperty("queue_procs")]
        public int QueueProcs { get; set; }

        [JsonProperty("queue_slave_procs")]
        public int QueueSlaveProcs { get; set; }

        [JsonProperty("plugins")]
        public int Plugins { get; set; }

        [JsonProperty("other_proc")]
        public int OtherProc { get; set; }

        [JsonProperty("mnesia")]
        public int Mnesia { get; set; }

        [JsonProperty("mgmt_db")]
        public int MgmtDb { get; set; }

        [JsonProperty("msg_index")]
        public int MsgIndex { get; set; }

        [JsonProperty("other_ets")]
        public int OtherEts { get; set; }

        [JsonProperty("binary")]
        public int Binary { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("atom")]
        public int Atom { get; set; }

        [JsonProperty("other_system")]
        public int OtherSystem { get; set; }
    }
}