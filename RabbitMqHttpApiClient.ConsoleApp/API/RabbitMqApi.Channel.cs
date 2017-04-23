using System.Collections.Generic;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.ConsoleApp.Models.ChannelModel;
using RabbitMqHttpApiClient.ConsoleApp.Utils;

namespace RabbitMqHttpApiClient.ConsoleApp.API
{
    public partial class RabbitMqApi//.Channel
    {
        /// <summary>
        /// List of all channels for a given connection.
        /// </summary>
        public async Task<IEnumerable<Channel>> GetChannelsByConnection(string connectionName)
        {
            return await DoGetCall<IEnumerable<Channel>>($"/api/connections/{connectionName.Encode()}/channels");
        }

        /// <summary>
        /// A list of all open channels.
        /// </summary>
        public async Task<IEnumerable<Channel>> GetChannels()
        {
            return await DoGetCall<IEnumerable<Channel>>("/api/channels");
        }

        /// <summary>
        /// A list of all open channels in a specific vhost.
        /// </summary>
        public async Task<IEnumerable<Channel>> GetChannelsByVhost(string virtualHost)
        {
            return await DoGetCall<IEnumerable<Channel>>($"/api/vhosts/{virtualHost.Encode()}/channels");
        }

        /// <summary>
        /// Details about an individual channel by name
        /// </summary>
        public async Task<Channel> GetChannel(string channelName)
        {
            return await DoGetCall<Channel>($"/api/channels/{channelName.Encode()}");
        }
    }
}