using CustomerApi.Models;
using System.Threading.Tasks;

namespace CustomerApi.Components.Interfaces
{
    public interface ICustomerComponent
    {
        Task<Customer> Add(CustomerDetails customerDetails);
    }
}