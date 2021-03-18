using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CustomerApi.Components.Interfaces;
using CustomerApi.Models;

namespace CustomerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerComponent _customerComponent;

        public CustomerController(ILogger<CustomerController> logger, ICustomerComponent customerComponent)
        {
            _logger = logger;
            _customerComponent = customerComponent;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CustomerDetails customerDetails)
        {
            var result = await _customerComponent.Add(customerDetails);
            return Ok(result);
        }
    }
}
