using CustomerApi.Components.Interfaces;
using CustomerApi.Messaging.Interfaces;
using CustomerApi.Models;
using CustomerApi.Repositories.Interfaces;
using System.Threading.Tasks;

namespace CustomerApi.Components
{
    public class CustomerComponent : ICustomerComponent
    {
        private readonly IRepository<CustomerDetails, Customer> _repository;
        private readonly IMessageBus _messageBus;
        public CustomerComponent(IRepository<CustomerDetails, Customer> repository, IMessageBus messageBus)
        {
            _repository = repository;
            _messageBus = messageBus;
        }
        public async Task<Customer> Add(CustomerDetails customerDetails)
        {
            var result = await _repository.Add(customerDetails);
            await _messageBus.Publish(result);
            return result;
        }
    }
}