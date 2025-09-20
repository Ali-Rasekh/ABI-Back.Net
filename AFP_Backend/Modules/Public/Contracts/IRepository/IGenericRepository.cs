
namespace AFP_Backend.Modules.Public.Contracts.IRepository;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<bool> ExistAsync(int id);
    Task<T> CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
