using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.Models.SystemInfoModel
{
    public class HealthCheck
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reason")]
        public string ErrorReason { get; set; }

        public bool IsOk => Status == "ok";
    }
}