using System.Collections.Generic;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.Models.DefinitionModel;
using RabbitMqHttpApiClient.Utils;

namespace RabbitMqHttpApiClient.API
{
    public partial class RabbitMqApi//.User
    {
        /// <summary>
        /// A list of all users.
        /// </summary>
        public async Task<IEnumerable<User>> GetUsers() => await DoGetCall<IEnumerable<User>>("/api/users");

        /// <summary>
        /// An individual virtual user.
        /// </summary>
        public async Task<User> GetUserByName(string username)
        {
            return await DoGetCall<User>($"/api/users/{username.Encode()}");
        }

        /// <summary>
        /// A list of all permissions for a given user.
        /// </summary>
        public async Task<IEnumerable<Permission>> GetUserPermissions(string username)
        {
            return await DoGetCall<IEnumerable<Permission>>($"/api/users/{username.Encode()}/permissions");
        }

        /// <summary>
        /// Details of the currently authenticated user.
        /// </summary>
        public async Task<WhoAmI> GetAuthenticatedUserInfo() => await DoGetCall<WhoAmI>("/api/whoami");
    }
}