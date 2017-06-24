using System.Collections.Generic;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.Models.ClusterModel;
using RabbitMqHttpApiClient.Models.SystemInfoModel;
using RabbitMqHttpApiClient.Models.SystemInfoModel.OverviewInfo;
using RabbitMqHttpApiClient.Utils;

namespace RabbitMqHttpApiClient.API
{
    public partial class RabbitMqApi//.SystemInfo
    {
        /// <summary>
        /// Various random bits of information that describe the whole system.
        /// </summary>
        public async Task<Overview> GetOverview() => await DoGetCall<Overview>("/api/overview");

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

        /// <summary>
        /// Checks the aliveness of a given virtual host
        /// Declares a test queue, then publishes and consumes a message. Intended for use by monitoring tools. 
        /// </summary>
        public async Task<HealthCheck> GetVirtualHostHealthcheck(string virtualHostName)
        {
            return await DoGetCall<HealthCheck>($"/api/aliveness-test/{virtualHostName.Encode()}");
        }

        /// <summary>
        /// Runs basic healthchecks in the current node. 
        /// Checks that the rabbit application is running, channels and queues can be listed successfully, 
        /// and that no alarms are in effect.
        /// </summary>
        public async Task<HealthCheck> GetCurrentNodeHeathcheck() => await DoGetCall<HealthCheck>("/api/healthchecks/node");

        /// <summary>
        /// Runs basic healthchecks in the given node. 
        /// Checks that the rabbit application is running, list_channels and list_queues return, and that no alarms are raised.
        /// </summary>
        public async Task<HealthCheck> GetNodeHealthcheck(string nodeName)
        {
            return await DoGetCall<HealthCheck>($"/api/healthchecks/node/{nodeName.Encode()}");
        }
    }
}