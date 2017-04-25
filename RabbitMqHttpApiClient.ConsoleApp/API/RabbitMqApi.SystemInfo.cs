using System.Collections.Generic;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.ConsoleApp.Models.ClusterModel;
using RabbitMqHttpApiClient.ConsoleApp.Models.ExtensionModel;
using RabbitMqHttpApiClient.ConsoleApp.Models.OverviewModel;

namespace RabbitMqHttpApiClient.ConsoleApp.API
{
    public partial class RabbitMqApi//.SystemInfo
    {
        /// <summary>
        /// Various random bits of information that describe the whole system.
        /// </summary>
        public async Task<Overview> GetOverview()
        {
            return await DoGetCall<Overview>("/api/overview");
        }

        /// <summary>
        /// Name identifying this RabbitMQ cluster.
        /// </summary>
        public async Task<string> GetClusterName()
        {
            var response = await DoGetCall<Cluster>("/api/cluster-name");
            return response.Name;
        }

        /// <summary>
        /// A list of extensions to the management plugin.
        /// </summary>
        public async Task<IEnumerable<ManagementPluginExtension>> GetExtensions()
        {
            return await DoGetCall<IEnumerable<ManagementPluginExtension>>("/api/extensions");
        }
    }
}