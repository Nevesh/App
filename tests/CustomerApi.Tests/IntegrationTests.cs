using System;
using Xunit;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CustomerApi.Models;
using System.Text;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;

namespace CustomerApi.Tests
{
    public class IntegrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        protected readonly HttpClient _client;

        public IntegrationTest(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task CustomerControllerPost_WhenGivenValidUserDetailsWithNoProcessingErrors_ShouldRespondSuccessWithCustomerInformation()
        {
            //Arrange & Act
            var request = new CustomerDetails
            {
                FirstName = "TestName",
                LastName = "TestLastName"
            };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/customer", content);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            var customer = JsonConvert.DeserializeObject<Customer>(stringResponse);

            //Assert
            Assert.Equal(request.FirstName, customer.Details.FirstName);
            Assert.Equal(request.LastName, customer.Details.LastName);
        }
    }
}
