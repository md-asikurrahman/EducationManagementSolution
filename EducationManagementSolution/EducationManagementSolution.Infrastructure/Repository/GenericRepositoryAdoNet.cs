using EducationManagementSolution.Application.Interfaces;

namespace EducationManagementSolution.Infrastructure.Repository;

public class GenericRepositoryAdoNet<TEntity> : IGenericRepositoryAdoNet<TEntity> where TEntity : class
{
}
