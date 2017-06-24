using System.Collections.Generic;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.Models.DefinitionModel;
using RabbitMqHttpApiClient.Utils;
using VirtualHost = RabbitMqHttpApiClient.Models.VirtualHostModel.VirtualHost;

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

        /// <summary>
        /// A list of all permissions for a given virtual host.
        /// </summary>
        public async Task<IEnumerable<Permission>> GetVirtualHostPermissions(string virtualHostName)
        {
            return await DoGetCall<IEnumerable<Permission>>($"/api/vhosts/{virtualHostName.Encode()}/permissions");
        }
    }
}