namespace RabbitMqHttpApiClient.ConsoleApp.Models.MessageQueueModel
{
    public class GarbageCollection
    {
        public int min_bin_vheap_size { get; set; }
        public int min_heap_size { get; set; }
        public int fullsweep_after { get; set; }
        public int minor_gcs { get; set; }
    }
}