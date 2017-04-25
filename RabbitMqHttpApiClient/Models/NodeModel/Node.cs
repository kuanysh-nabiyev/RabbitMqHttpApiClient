using Newtonsoft.Json;
using RabbitMqHttpApiClient.Models.Common;

namespace RabbitMqHttpApiClient.Models.NodeModel
{
    public class Node
    {
        [JsonProperty("binary")]
        public NodeBinary Binary { get; set; }

        [JsonProperty("memory")]
        public NodeMemory Memory { get; set; }

        [JsonProperty("cluster_links")]
        public object[] ClusterLinks { get; set; }

        [JsonProperty("mem_used")]
        public int MemUsed { get; set; }

        [JsonProperty("mem_used_details")]
        public RateDetails MemUsedDetails { get; set; }

        [JsonProperty("fd_used")]
        public int FdUsed { get; set; }

        [JsonProperty("fd_used_details")]
        public RateDetails FdUsedDetails { get; set; }

        [JsonProperty("sockets_used")]
        public int SocketsUsed { get; set; }

        [JsonProperty("sockets_used_details")]
        public RateDetails SocketsUsedDetails { get; set; }

        [JsonProperty("proc_used")]
        public int ProcUsed { get; set; }

        [JsonProperty("proc_used_details")]
        public RateDetails ProcUsedDetails { get; set; }

        [JsonProperty("disk_free")]
        public long DiskFree { get; set; }

        [JsonProperty("disk_free_details")]
        public RateDetails DiskFreeDetails { get; set; }

        [JsonProperty("io_read_count")]
        public int IoReadCount { get; set; }

        [JsonProperty("io_read_count_details")]
        public RateDetails IoReadCountDetails { get; set; }

        [JsonProperty("io_read_bytes")]
        public int IoReadBytes { get; set; }

        [JsonProperty("io_read_bytes_details")]
        public RateDetails IoReadBytesDetails { get; set; }

        [JsonProperty("io_read_avg_time")]
        public double IoReadAvgTime { get; set; }

        [JsonProperty("io_read_avg_time_details")]
        public RateDetails IoReadAvgTimeDetails { get; set; }

        [JsonProperty("io_write_count")]
        public int IoWriteCount { get; set; }

        [JsonProperty("io_write_count_details")]
        public RateDetails IoWriteCountDetails { get; set; }

        [JsonProperty("io_write_bytes")]
        public int IoWriteBytes { get; set; }

        [JsonProperty("io_write_bytes_details")]
        public RateDetails IoWriteBytesDetails { get; set; }

        [JsonProperty("io_write_avg_time")]
        public double IoWriteAvgTime { get; set; }

        [JsonProperty("io_write_avg_time_details")]
        public RateDetails IoWriteAvgTimeDetails { get; set; }

        [JsonProperty("io_sync_count")]
        public int IoSyncCount { get; set; }

        [JsonProperty("io_sync_count_details")]
        public RateDetails IoSyncCountDetails { get; set; }

        [JsonProperty("io_sync_avg_time")]
        public double IoSyncAvgTime { get; set; }

        [JsonProperty("io_sync_avg_time_details")]
        public RateDetails IoSyncAvgTimeDetails { get; set; }

        [JsonProperty("io_seek_count")]
        public int IoSeekCount { get; set; }

        [JsonProperty("io_seek_count_details")]
        public RateDetails IoSeekCountDetails { get; set; }

        [JsonProperty("io_seek_avg_time")]
        public double IoSeekAvgTime { get; set; }

        [JsonProperty("io_seek_avg_time_details")]
        public RateDetails IoSeekAvgTimeDetails { get; set; }

        [JsonProperty("io_reopen_count")]
        public int IoReopenCount { get; set; }

        [JsonProperty("io_reopen_count_details")]
        public RateDetails IoReopenCountDetails { get; set; }

        [JsonProperty("mnesia_ram_tx_count")]
        public int MnesiaRamTxCount { get; set; }

        [JsonProperty("mnesia_ram_tx_count_details")]
        public RateDetails MnesiaRamTxCountDetails { get; set; }

        [JsonProperty("mnesia_disk_tx_count")]
        public int MnesiaDiskTxCount { get; set; }

        [JsonProperty("mnesia_disk_tx_count_details")]
        public RateDetails MnesiaDiskTxCountDetails { get; set; }

        [JsonProperty("msg_store_read_count")]
        public int MsgStoreReadCount { get; set; }

        [JsonProperty("msg_store_read_count_details")]
        public RateDetails MsgStoreReadCountDetails { get; set; }

        [JsonProperty("msg_store_write_count")]
        public int MsgStoreWriteCount { get; set; }

        [JsonProperty("msg_store_write_count_details")]
        public RateDetails MsgStoreWriteCountDetails { get; set; }

        [JsonProperty("queue_index_journal_write_count")]
        public int QueueIndexJournalWriteCount { get; set; }

        [JsonProperty("queue_index_journal_write_count_details")]
        public RateDetails QueueIndexJournalWriteCountDetails { get; set; }

        [JsonProperty("queue_index_write_count")]
        public int QueueIndexWriteCount { get; set; }

        [JsonProperty("queue_index_write_count_details")]
        public RateDetails QueueIndexWriteCountDetails { get; set; }

        [JsonProperty("queue_index_read_count")]
        public int QueueIndexReadCount { get; set; }

        [JsonProperty("queue_index_read_count_details")]
        public RateDetails QueueIndexReadCountDetails { get; set; }

        [JsonProperty("gc_num")]
        public int GcNum { get; set; }

        [JsonProperty("gc_num_details")]
        public RateDetails GcNumDetails { get; set; }

        [JsonProperty("gc_bytes_reclaimed")]
        public long GcBytesReclaimed { get; set; }

        [JsonProperty("gc_bytes_reclaimed_details")]
        public RateDetails GcBytesReclaimedDetails { get; set; }

        [JsonProperty("context_switches")]
        public int ContextSwitches { get; set; }

        [JsonProperty("context_switches_details")]
        public RateDetails ContextSwitchesDetails { get; set; }

        [JsonProperty("io_file_handle_open_attempt_count")]
        public int IoFileHandleOpenAttemptCount { get; set; }

        [JsonProperty("io_file_handle_open_attempt_count_details")]
        public RateDetails IoFileHandleOpenAttemptCountDetails { get; set; }

        [JsonProperty("io_file_handle_open_attempt_avg_time")]
        public double IoFileHandleOpenAttemptAvgTime { get; set; }

        [JsonProperty("io_file_handle_open_attempt_avg_time_details")]
        public RateDetails IoFileHandleOpenAttemptAvgTimeDetails { get; set; }

        [JsonProperty("partitions")]
        public object[] Partitions { get; set; }

        [JsonProperty("os_pid")]
        public string OsPid { get; set; }

        [JsonProperty("fd_total")]
        public int FdTotal { get; set; }

        [JsonProperty("sockets_total")]
        public int SocketsTotal { get; set; }

        [JsonProperty("mem_limit")]
        public long MemLimit { get; set; }

        [JsonProperty("mem_alarm")]
        public bool MemAlarm { get; set; }

        [JsonProperty("disk_free_limit")]
        public int DiskFreeLimit { get; set; }

        [JsonProperty("disk_free_alarm")]
        public bool DiskFreeAlarm { get; set; }

        [JsonProperty("proc_total")]
        public int ProcTotal { get; set; }

        [JsonProperty("rates_mode")]
        public string RatesMode { get; set; }

        [JsonProperty("uptime")]
        public double Uptime { get; set; }

        [JsonProperty("run_queue")]
        public int RunQueue { get; set; }

        [JsonProperty("processors")]
        public int Processors { get; set; }

        [JsonProperty("exchange_types")]
        public ExchangeType[] ExchangeTypes { get; set; }

        [JsonProperty("auth_mechanisms")]
        public AuthMechanism[] AuthMechanisms { get; set; }

        [JsonProperty("applications")]
        public Application[] Applications { get; set; }

        [JsonProperty("contexts")]
        public Context[] Contexts { get; set; }

        [JsonProperty("log_file")]
        public string LogFile { get; set; }

        [JsonProperty("sasl_log_file")]
        public string SaslLogFile { get; set; }

        [JsonProperty("db_dir")]
        public string DbDir { get; set; }

        [JsonProperty("config_files")]
        public string[] ConfigFiles { get; set; }

        [JsonProperty("net_ticktime")]
        public double NetTicktime { get; set; }

        [JsonProperty("enabled_plugins")]
        public string[] EnabledPlugins { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("running")]
        public bool Running { get; set; }
    }
}