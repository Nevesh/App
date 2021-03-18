using CustomerApi.Messaging.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CustomerApi.Messaging
{
    public class MessageBus : IMessageBus
    {
        private readonly ILogger<MessageBus> _logger;
        public MessageBus(ILogger<MessageBus> logger)
        {
            _logger = logger;
        }
        public Task Publish<T>(T model)
        {
            var message = JsonConvert.SerializeObject(model);
            _logger.LogInformation(message);
            return Task.CompletedTask;
        }
    }
}