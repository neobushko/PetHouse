namespace DataAccessLayer.Interfaces;

public interface IRepository<T>
{
    public Task<Guid> AddAsync(T pet);

    public Task<bool> UpdateAsync(T pet);

    public Task<T?> GetAsync(Guid id);

    public Task<IEnumerable<T>> GetAllAsync();

    public Task<bool> Delete(Guid id);
}
