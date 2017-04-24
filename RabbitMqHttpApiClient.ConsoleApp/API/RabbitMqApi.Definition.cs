using System.Threading.Tasks;
using RabbitMqHttpApiClient.ConsoleApp.Models.DefinitionModel;
using RabbitMqHttpApiClient.ConsoleApp.Utils;

namespace RabbitMqHttpApiClient.ConsoleApp.API
{
    public partial class RabbitMqApi//.Definition
    {
        /// <summary>
        /// The server definitions - exchanges, queues, bindings, users, virtual hosts, permissions and parameters. Everything apart from messages.
        /// </summary>
        public async Task<GetDefinitionsResponse> GetDefinitions()
        {
            return await DoGetCall<GetDefinitionsResponse>("/api/definitions");
        }

        /// <summary>
        /// The server definitions for a given virtual host - exchanges, queues, bindings and policies. 
        /// </summary>
        public async Task<GetDefinitionByVhostResponse> GetDefinitionByVhost(string virtualHost)
        {
            return await DoGetCall<GetDefinitionByVhostResponse>($"/api/definitions/{virtualHost.Encode()}");
        }
    }
}