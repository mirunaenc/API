

namespace Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> InsertAsync(T obj);
        Task<T> UpdateAsync(int id, T obj);
        Task DeleteAsync(int id);
    }
}
