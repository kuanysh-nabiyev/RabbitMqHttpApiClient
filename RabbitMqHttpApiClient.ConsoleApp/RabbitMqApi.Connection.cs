using System.Collections.Generic;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.ConsoleApp.Models.ConnectionModel;

namespace RabbitMqHttpApiClient.ConsoleApp
{
    public partial class RabbitMqApi
    {
		/// <summary>
        /// A list of all open connections.
        /// </summary>
        public async Task<IEnumerable<Connection>> GetConnections()
        {
            return await DoGetCall<IEnumerable<Connection>>("/api/connections");
        }

        /// <summary>
        /// A list of all open connections in a specific vhost.
        /// </summary>
        public async Task<IEnumerable<Connection>> GetConnectionsByVhost(string virtualHost)
        {
            if (virtualHost == "/") virtualHost = "%2F";
            return await DoGetCall<IEnumerable<Connection>>($"/api/vhosts/{virtualHost}/connections");
        }
    }
}