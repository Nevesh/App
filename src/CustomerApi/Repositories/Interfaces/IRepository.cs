using System.Threading.Tasks;

namespace CustomerApi.Repositories.Interfaces
{
    public interface IRepository<T, R>
    {
        Task<R> Add(T model);
    }
}