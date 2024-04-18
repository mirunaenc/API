

namespace Core.Interfaces
{
    public interface IArtistService<T> where T : class
    {
        Task<IEnumerable<Artist>> GetAllAsync();

        Task<Artist> GetByIdAsync(int id);

        Task InsertAsync(Artist artist);

        Task UpdateAsync(int id, Artist artist);

        Task DeleteAsync(int id);
    }
}
