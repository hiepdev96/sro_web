using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefServerEventExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefServerEvent GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefServerEvent> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefServerEvent> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefServerEvent> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefServerEvent> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefServerEvent> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefServerEvent>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefServerEvent> ByName(this IQueryable<VsroShard.Shard_Repository.Entities.RefServerEvent> queryable, string name)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Name == name);
        }

        #endregion

    }
}
