namespace CustomerApi.Models
{
    public class Customer
    {
        public int Id { get; set;}
        public CustomerStatus Status { get; set;}
        public CustomerDetails Details { get; set;}
    }
}