using AutoMapper;
using RateApplication.Interfaces;

namespace RateApplication.Services;

public class GenericService<T1, T2>: IService<T1, T2> 
    where T1: class
    where T2: class
{
    protected IRepository<T1> Repository;
    protected IMapper Mapper;

    public GenericService(IRepository<T1> repository)
    {
        Repository = repository;
        MapperConfiguration configuration = new MapperConfiguration(options =>
        {
            options.CreateMap<T1, T2>();
            options.CreateMap<T2, T1>();
        });

        Mapper = new Mapper(configuration);
    }

    public async Task AddAsync(T2 newItem)
    {
        var item = Mapper.Map<T2, T1>(newItem);
        await Repository.AddAsync(item);
    }

    public async Task DeleteAsync(T2 item)
    {
        var delItem = Mapper.Map<T2, T1>(item);
        await Repository.RemoveAsync(delItem);
    }

    public async Task UpdateAsync(T2 updatedItem)
    {
        var item = Mapper.Map<T2, T1>(updatedItem);
        await Repository.UpdateAsync(item);
    }

    public Task<IEnumerable<T2>> GetAll()
    {
        var result = Repository.GetAll().Select(elem => Mapper.Map<T1,T2>(elem));
        return Task.FromResult(result);
    }

    public T2 GetById(int id)
    {
        var element = Repository.GetById(id);
        return Mapper.Map<T1,T2>(element!);
    }

    public async Task<T2> GetByIdAsync(int id)
    {
        var element = await Repository.GetByIdAsync(id);
        return Mapper.Map<T1, T2>(element!);
    }
}