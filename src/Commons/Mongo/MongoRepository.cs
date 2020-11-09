using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AdvancedInfoService.Mimo.GitLabService.Commons.Types;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace AdvancedInfoService.Mimo.gitlabservice.Commons.Mongo
{
    public class MongoRepository<TEntity> : IMongoRepository<TEntity> where TEntity : IIdentifiable
    {
        public IMongoCollection<TEntity> Collection { get; }

        public MongoRepository(IMongoDatabase database, string collectionName)
        {
            Collection = database.GetCollection<TEntity>(collectionName);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
            => await Collection.Find(predicate).SingleOrDefaultAsync();

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
            => await Collection.Find(predicate).ToListAsync();

        public async Task<PageResult<TEntity>> BrowseAsync<TQuery>(Expression<Func<TEntity, bool>> predicate,
                TQuery query) where TQuery : PagedQueryBase
            => await Collection.AsQueryable().Where(predicate).PaginateAsync(query);

        public async Task AddAsync(TEntity entity)
            => await Collection.InsertOneAsync(entity);

        public async Task UpdateAsync(Expression<Func<TEntity, bool>> predicate, TEntity entity)
            => await Collection.ReplaceOneAsync(predicate, entity);

        public async Task DeleteAsync(Expression<Func<TEntity, bool>> predicate)
            => await Collection.DeleteOneAsync(predicate);
        

        public async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate)
            => await Collection.Find(predicate).AnyAsync();

        public async Task AddManyAsync(IEnumerable<TEntity> entity)
            => await Collection.InsertManyAsync(entity);

        public async Task DeleteManyAsync(Expression<Func<TEntity, bool>> predicate)
            => await Collection.DeleteManyAsync(predicate);

    }
}
