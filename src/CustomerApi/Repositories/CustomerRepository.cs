using CustomerApi.Models;
using CustomerApi.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CustomerApi.Repositories
{
    public class CustomerRepository : IRepository<CustomerDetails, Customer>
    {
        private readonly ILogger<CustomerRepository> _logger;
        public CustomerRepository(ILogger<CustomerRepository> logger)
        {
            _logger = logger;
        }
        public Task<Customer> Add(CustomerDetails customerDetails)
        {
            return Task.FromResult(new Customer
            {
                Details = customerDetails,
                Id = 1,
                Status = CustomerStatus.Provisional
            });
        }
    }
}