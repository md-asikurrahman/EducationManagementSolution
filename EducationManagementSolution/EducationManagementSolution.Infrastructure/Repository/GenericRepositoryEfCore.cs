using Microsoft.EntityFrameworkCore;
using EducationManagementSolution.Application.Interfaces;

namespace EducationManagementSolution.Infrastructure.Repository;

public class GenericRepositoryEfCore<TEntity> : IGenericRepositoryEfCore<TEntity> where TEntity : class
{
    private DbContext DbContext;
    public DbSet<TEntity> DbSet { get; }
    public GenericRepositoryEfCore(DbContext Context)
    {
            Context = DbContext;
            DbSet = Context.Set<TEntity>();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<TEntity> GetByNameAsync(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<TEntity> SaveAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
    public async Task<TEntity> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}
