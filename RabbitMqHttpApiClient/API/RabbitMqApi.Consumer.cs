﻿using System.Collections.Generic;
using System.Threading.Tasks;
using RabbitMqHttpApiClient.Models.ConsumerModel;
using RabbitMqHttpApiClient.Utils;

namespace RabbitMqHttpApiClient.API
{
    public partial class RabbitMqApi//.Consumer
    {
        /// <summary>
        /// A list of all consumers.
        /// </summary>
        public async Task<IEnumerable<Consumer>> GetConsumers()
        {
            return await DoGetCall<IEnumerable<Consumer>>("api/consumers");
        }

        /// <summary>
        /// A list of all consumers in a given virtual host.
        /// </summary>
        public async Task<IEnumerable<Consumer>> GetConsumersByVhost(string virtualHost)
        {
            return await DoGetCall<IEnumerable<Consumer>>($"api/consumers/{virtualHost.Encode()}");
        }
    }
}