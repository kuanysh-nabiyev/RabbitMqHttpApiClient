using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitMqHttpApiClient.API;
using RabbitMqHttpApiClient.Models.QueueModel;

namespace WebApplicationBasic.Controllers
{
    public class QueueController : Controller
    {
        private readonly RabbitMqApi _rabbitMqApi;

        public QueueController(RabbitMqApi rabbitMqApi)
        {
            _rabbitMqApi = rabbitMqApi;
        }

        [HttpGet("/api/queues")]
        public async Task<dynamic> GetQueues()
        {
            var queues = await _rabbitMqApi.GetQueues();

            return queues.Select(item => new 
            {
                Name = item.Name,
                VirtualHost = item.Vhost,
                State = item.State,
                TotalMessagesQuantity = item.Messages,
                ReadyMessagesQuantity = item.MessagesReady,
                UnackedMessagesQuantity = item.MessagesUnacknowledged
            });
        }

        [HttpGet("/api/queues/{name}")]
        public async Task<dynamic> GetQueueByName(string name)
        {
            var queue = await _rabbitMqApi.GetQueueByVhostAndName("/", name);
            var messages = await _rabbitMqApi.GetQueueMessages("/", name);

            return new {
                Name = queue.Name,
                Messages = messages.Select(item => new 
                {
                    Payload = item.Payload,
                    PayloadBytes = item.PayloadBytes     
                })
            };
        }
    }
}
