using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.QueueModel
{
    public class GarbageCollection
    {
        [JsonProperty("max_heap_size")]
        public int MaxHeapSize { get; set; }

        [JsonProperty("min_bin_vheap_size")]
        public int MinBinVheapSize { get; set; }

        [JsonProperty("min_heap_size")]
        public int MinHeapSize { get; set; }

        [JsonProperty("fullsweep_after")]
        public int FullsweepAfter { get; set; }

        [JsonProperty("minor_gcs")]
        public int MinorGcs { get; set; }
    }
}