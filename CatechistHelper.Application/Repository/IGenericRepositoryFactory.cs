using static CatechistHelper.Application.Repository.IGenericRepository;

namespace CatechistHelper.Application.Repository
{
    public interface IGenericRepositoryFactory
    {
        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }
}
