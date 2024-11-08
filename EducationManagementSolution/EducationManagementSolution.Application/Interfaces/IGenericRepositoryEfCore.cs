namespace EducationManagementSolution.Application.Interfaces;

public interface IGenericRepositoryEfCore<TEntity> : IDisposable,IComparable where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(int id);
    Task<TEntity> GetByNameAsync(string name);
    //Task<TEntity> GetByEmailAsync(string email);
    Task<TEntity> SaveAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<TEntity> DeleteAsync(int id);
}
