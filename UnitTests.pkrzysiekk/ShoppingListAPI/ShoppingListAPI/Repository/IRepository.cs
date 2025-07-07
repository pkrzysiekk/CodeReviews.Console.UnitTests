namespace ShoppingListAPI.Repository;

public interface IRepository<T>
{
    public Task<T> GetById(int id);
    public Task<IEnumerable<T>> GetAll();
    public Task Add(T item);
    public Task Update(T item);
    public Task Delete(T item);
}