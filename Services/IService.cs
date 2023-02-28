namespace RateApplication.Services;

public interface IService<T1, T2> 
    where T1 : class 
    where T2 : class
{
    Task AddAsync(T2 newItem);
    Task DeleteAsync(T2 item);
    Task UpdateAsync(T2 updatedItem);
    Task<IEnumerable<T2>> GetAll();
    T2 GetById(int id);
    Task<T2> GetByIdAsync(int id);
}
