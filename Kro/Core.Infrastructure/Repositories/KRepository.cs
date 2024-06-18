using Core.Domain.Entities;
using Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Infrastructure.Repositories;

public class KRepository<TEntity> : IKRepository<TEntity> 
    where TEntity : class, IKEntity
{
    protected readonly IServiceProvider ServiceProvider;
    protected readonly DbContext Context;

    protected KRepository(IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
        Context = serviceProvider.GetRequiredService<DbContext>();
    }

    public IQueryable<TEntity> GetQueryable()
    {
        return Context.Set<TEntity>().AsQueryable();
    }

    public async Task CreateAsync(TEntity entity, bool save = true)
    {
        Context.Set<TEntity>().Add(entity);
        
        if (!save) return;
        await Context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity, bool save = true)
    {
        Context.Set<TEntity>().Update(entity);
        
        if (!save) return;
        await Context.SaveChangesAsync();
    }

    public async Task DeleteAsync(TEntity entity, bool save = true)
    {
        Context.Set<TEntity>().Remove(entity);

        if (!save) return;

        await Context.SaveChangesAsync();
    }
}