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
        public async Task<IEnumerable<Queue>> GetQueues()
        {
            return await _rabbitMqApi.GetQueues();
        }
    }
}
