namespace RabbitMqHttpApiClient.ConsoleApp.Models.NodeModel
{
    public class NodeMemory
    {
        public int total { get; set; }
        public int connection_readers { get; set; }
        public int connection_writers { get; set; }
        public int connection_channels { get; set; }
        public int connection_other { get; set; }
        public int queue_procs { get; set; }
        public int queue_slave_procs { get; set; }
        public int plugins { get; set; }
        public int other_proc { get; set; }
        public int mnesia { get; set; }
        public int mgmt_db { get; set; }
        public int msg_index { get; set; }
        public int other_ets { get; set; }
        public int binary { get; set; }
        public int code { get; set; }
        public int atom { get; set; }
        public int other_system { get; set; }
    }
}