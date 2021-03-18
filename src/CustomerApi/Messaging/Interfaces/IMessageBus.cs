using System.Threading.Tasks;

namespace CustomerApi.Messaging.Interfaces
{
    public interface IMessageBus
    {
        Task Publish<T>(T model);
    }
}