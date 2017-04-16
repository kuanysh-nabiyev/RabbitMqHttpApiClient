using System.Collections.Generic;
using RabbitMqHttpApiClient.ConsoleApp.Models.Common;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.NodeModel
{
    public class Node
    {
        public NodeBinary binary { get; set; }
        public NodeMemory memory { get; set; }
        public IEnumerable<object> cluster_links { get; set; }
        public int mem_used { get; set; }
        public RateDetails mem_used_details { get; set; }
        public int fd_used { get; set; }
        public RateDetails fd_used_details { get; set; }
        public int sockets_used { get; set; }
        public RateDetails sockets_used_details { get; set; }
        public int proc_used { get; set; }
        public RateDetails proc_used_details { get; set; }
        public long disk_free { get; set; }
        public RateDetails disk_free_details { get; set; }
        public int io_read_count { get; set; }
        public RateDetails io_read_count_details { get; set; }
        public int io_read_bytes { get; set; }
        public RateDetails io_read_bytes_details { get; set; }
        public double io_read_avg_time { get; set; }
        public RateDetails io_read_avg_time_details { get; set; }
        public int io_write_count { get; set; }
        public RateDetails io_write_count_details { get; set; }
        public int io_write_bytes { get; set; }
        public RateDetails io_write_bytes_details { get; set; }
        public double io_write_avg_time { get; set; }
        public RateDetails io_write_avg_time_details { get; set; }
        public int io_sync_count { get; set; }
        public RateDetails io_sync_count_details { get; set; }
        public double io_sync_avg_time { get; set; }
        public RateDetails io_sync_avg_time_details { get; set; }
        public int io_seek_count { get; set; }
        public RateDetails io_seek_count_details { get; set; }
        public double io_seek_avg_time { get; set; }
        public RateDetails io_seek_avg_time_details { get; set; }
        public int io_reopen_count { get; set; }
        public RateDetails io_reopen_count_details { get; set; }
        public int mnesia_ram_tx_count { get; set; }
        public RateDetails mnesia_ram_tx_count_details { get; set; }
        public int mnesia_disk_tx_count { get; set; }
        public RateDetails mnesia_disk_tx_count_details { get; set; }
        public int msg_store_read_count { get; set; }
        public RateDetails msg_store_read_count_details { get; set; }
        public int msg_store_write_count { get; set; }
        public RateDetails msg_store_write_count_details { get; set; }
        public int queue_index_journal_write_count { get; set; }
        public RateDetails queue_index_journal_write_count_details { get; set; }
        public int queue_index_write_count { get; set; }
        public RateDetails queue_index_write_count_details { get; set; }
        public int queue_index_read_count { get; set; }
        public RateDetails queue_index_read_count_details { get; set; }
        public int gc_num { get; set; }
        public RateDetails gc_num_details { get; set; }
        public long gc_bytes_reclaimed { get; set; }
        public RateDetails gc_bytes_reclaimed_details { get; set; }
        public int context_switches { get; set; }
        public RateDetails context_switches_details { get; set; }
        public int io_file_handle_open_attempt_count { get; set; }
        public RateDetails io_file_handle_open_attempt_count_details { get; set; }
        public double io_file_handle_open_attempt_avg_time { get; set; }
        public RateDetails io_file_handle_open_attempt_avg_time_details { get; set; }
        public IEnumerable<object> partitions { get; set; }
        public string os_pid { get; set; }
        public int fd_total { get; set; }
        public int sockets_total { get; set; }
        public long mem_limit { get; set; }
        public bool mem_alarm { get; set; }
        public int disk_free_limit { get; set; }
        public bool disk_free_alarm { get; set; }
        public int proc_total { get; set; }
        public string rates_mode { get; set; }
        public double uptime { get; set; }
        public int run_queue { get; set; }
        public int processors { get; set; }
        public IEnumerable<ExchangeType> exchange_types { get; set; }
        public IEnumerable<AuthMechanism> auth_mechanisms { get; set; }
        public IEnumerable<Application> applications { get; set; }
        public IEnumerable<Context> contexts { get; set; }
        public string log_file { get; set; }
        public string sasl_log_file { get; set; }
        public string db_dir { get; set; }
        public IEnumerable<string> config_files { get; set; }
        public double net_ticktime { get; set; }
        public IEnumerable<string> enabled_plugins { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public bool running { get; set; }
    }
}