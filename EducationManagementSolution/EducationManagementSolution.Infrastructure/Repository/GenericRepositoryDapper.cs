using EducationManagementSolution.Application.Interfaces;

namespace EducationManagementSolution.Infrastructure.Repository;

public class GenericRepositoryDapper<TEntity> : IGenericRepositoryDapper<TEntity> where TEntity : class 
{
}
