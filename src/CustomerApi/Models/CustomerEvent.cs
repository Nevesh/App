namespace CustomerApi.Models
{
    public class CustomerEvent
    {
        public int CustomerId { get; set;}
        public CustomerStatus Status { get; set;}
        public CustomerEventAction Action { get; set;}
    }
}