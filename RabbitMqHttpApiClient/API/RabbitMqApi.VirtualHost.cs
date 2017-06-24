using System.Collections.Generic;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.Models.VirtualHostModel;
using RabbitMqHttpApiClient.Utils;

namespace RabbitMqHttpApiClient.API
{
    public partial class RabbitMqApi//.VirtualHost
    {
        /// <summary>
        /// A list of all vhosts.
        /// </summary>
        public async Task<IEnumerable<VirtualHost>> GetVirtualHosts()
        {
            return await DoGetCall< IEnumerable<VirtualHost>>("/api/vhosts");
        }

        /// <summary>
        /// An individual virtual host.
        /// </summary>
        public async Task<VirtualHost> GetVirtualHostByName(string virtualHostName)
        {
            return await DoGetCall<VirtualHost>($"/api/vhosts/{virtualHostName.Encode()}");
        }
    }
}