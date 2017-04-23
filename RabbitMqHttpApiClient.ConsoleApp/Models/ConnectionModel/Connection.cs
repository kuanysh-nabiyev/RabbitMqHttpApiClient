using Newtonsoft.Json;
using RabbitMqHttpApiClient.ConsoleApp.Models.Common;

namespace RabbitMqHttpApiClient.ConsoleApp.Models.ConnectionModel
{
    public class Connection
    {
        [JsonProperty("connected_at")]
        public object ConnectedAt { get; set; }

        [JsonProperty("client_properties")]
        public ClientProperties ClientProperties { get; set; }

        [JsonProperty("channel_max")]
        public int ChannelMax { get; set; }

        [JsonProperty("frame_max")]
        public int FrameMax { get; set; }

        [JsonProperty("timeout")]
        public int Timeout { get; set; }

        [JsonProperty("vhost")]
        public string Vhost { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("ssl_hash")]
        public object SslHash { get; set; }

        [JsonProperty("ssl_cipher")]
        public object SslCipher { get; set; }

        [JsonProperty("ssl_key_exchange")]
        public object SslKeyExchange { get; set; }

        [JsonProperty("ssl_protocol")]
        public object SslProtocol { get; set; }

        [JsonProperty("auth_mechanism")]
        public string AuthMechanism { get; set; }

        [JsonProperty("peer_cert_validity")]
        public object PeerCertValidity { get; set; }

        [JsonProperty("peer_cert_issuer")]
        public object PeerCertIssuer { get; set; }

        [JsonProperty("peer_cert_subject")]
        public object PeerCertSubject { get; set; }

        [JsonProperty("ssl")]
        public bool Ssl { get; set; }

        [JsonProperty("peer_host")]
        public string PeerHost { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("peer_port")]
        public int PeerPort { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("garbage_collection")]
        public GarbageCollection GarbageCollection { get; set; }

        [JsonProperty("reductions")]
        public int Reductions { get; set; }

        [JsonProperty("channels")]
        public int Channels { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("send_pend")]
        public int SendPend { get; set; }

        [JsonProperty("send_cnt")]
        public int SendCnt { get; set; }

        [JsonProperty("recv_cnt")]
        public int RecvCnt { get; set; }

        [JsonProperty("recv_oct_details")]
        public RateDetails RecvOctDetails { get; set; }

        [JsonProperty("recv_oct")]
        public int RecvOct { get; set; }

        [JsonProperty("send_oct_details")]
        public RateDetails SendOctDetails { get; set; }

        [JsonProperty("send_oct")]
        public int SendOct { get; set; }

        [JsonProperty("reductions_details")]
        public RateDetails ReductionsDetails { get; set; }
    }
}
