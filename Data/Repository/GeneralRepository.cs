using Microsoft.EntityFrameworkCore;
using RateApplication.Interfaces;

namespace RateApplication.Data.Repository;

public class GeneralRepository<T> : IRepository<T> where T : class
{
    private ApplicationDbContext _db;
    private DbSet<T> _dbSet;

    public GeneralRepository(ApplicationDbContext applicationDbContext)
    {
        _db = applicationDbContext;
        _dbSet = applicationDbContext.Set<T>();
    }

    public T? GetById(int id)
    {
        var item = _dbSet.Find(id);
        return item;
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        var item = await _dbSet.FindAsync(id);
        return item;
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet;
    }

    public void Add(T item)
    {
        _dbSet.Add(item);
    }

    public async Task AddAsync(T item)
    {
        await _dbSet.AddAsync(item);
        await _db.SaveChangesAsync();
    }

    public void Update(T item)
    {
        _dbSet.Update(item);
        _db.SaveChanges();
    }

    public async Task UpdateAsync(T item)
    {
        _dbSet.Update(item);
        await _db.SaveChangesAsync();
    }

    public void Remove(T item)
    {
        _dbSet.Remove(item);
        _db.SaveChanges();
    }

    public async Task RemoveAsync(T item)
    {
        _dbSet.Remove(item);
        await _db.SaveChangesAsync();
    }
}