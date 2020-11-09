using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AdvancedInfoService.Mimo.GitLabService.Commons.Types;

namespace AdvancedInfoService.Mimo.gitlabservice.Commons.Mongo
{
    public interface IMongoRepository<TEntity> where TEntity : IIdentifiable
    {
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<PageResult<TEntity>> BrowseAsync<TQuery>(Expression<Func<TEntity, bool>> predicate,
               TQuery query) where TQuery : PagedQueryBase;
        Task AddAsync(TEntity entity);
        Task AddManyAsync(IEnumerable<TEntity> entity);
        Task UpdateAsync(Expression<Func<TEntity, bool>> predicate, TEntity entity);
        Task DeleteAsync(Expression<Func<TEntity, bool>> predicate);
        Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate);
        Task DeleteManyAsync(Expression<Func<TEntity, bool>> predicate);

    }
}
