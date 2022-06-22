using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class ItemsExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.Items GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.Items> queryable, long id64)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.Items> dbSet)
                return dbSet.Find(id64);

            return queryable.FirstOrDefault(q => q.Id64 == id64);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.Items> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.Items> queryable, long id64)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.Items> dbSet)
                return dbSet.FindAsync(id64);

            var task = queryable.FirstOrDefaultAsync(q => q.Id64 == id64);
            return new ValueTask<VsroShard.Shard_Repository.Entities.Items>(task);
        }

        #endregion

    }
}
