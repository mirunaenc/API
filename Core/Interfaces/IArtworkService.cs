

using Core.Entities;

namespace Core.Interfaces
{
    public interface IArtworkService<T> where T : class
    {
        Task<IEnumerable<Artwork>> GetAllAsync();

        Task<Artwork> GetByIdAsync(int id);

        Task InsertAsync(Artwork artwork);

        Task UpdateAsync(int id, Artwork artwork);

        Task DeleteAsync(int id);
    }
}
