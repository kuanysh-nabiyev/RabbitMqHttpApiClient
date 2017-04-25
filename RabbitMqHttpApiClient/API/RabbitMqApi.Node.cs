using System.Collections.Generic;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.Models.NodeModel;
using RabbitMqHttpApiClient.Utils;

namespace RabbitMqHttpApiClient.API
{
    public partial class RabbitMqApi//.Node
    {
        /// <summary>
        /// A list of nodes in the RabbitMQ cluster.
        /// </summary>
        public async Task<IEnumerable<Node>> GetNodes()
        {
            return await DoGetCall<IEnumerable<Node>>("/api/nodes");
        }

        /// <summary>
        /// An individual node in the RabbitMQ cluster
        /// </summary>
        /// <param name="nodeName">node name</param>
        /// <param name="withMemory">To get memory statistics</param>
        /// <param name="withBinary">to get a breakdown of binary memory use (may be expensive if there are many small binaries in the system)</param>
        /// <returns>Node details</returns>
        public async Task<Node> GetNode(string nodeName, bool withMemory = false, bool withBinary = false)
        {
            string memory = withMemory.ToString().ToLowerInvariant();
            string binary = withBinary.ToString().ToLowerInvariant();
            var path = $"/api/nodes/{nodeName.Encode()}?memory={memory}&binary={binary}";
            return await DoGetCall<Node>(path);
        }
    }
}