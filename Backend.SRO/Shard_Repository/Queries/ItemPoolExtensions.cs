using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class ItemPoolExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.ItemPool> ByInUse(this IQueryable<VsroShard.Shard_Repository.Entities.ItemPool> queryable, byte inUse)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.InUse == inUse);
        }

        public static VsroShard.Shard_Repository.Entities.ItemPool GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.ItemPool> queryable, long itemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.ItemPool> dbSet)
                return dbSet.Find(itemID);

            return queryable.FirstOrDefault(q => q.ItemID == itemID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.ItemPool> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.ItemPool> queryable, long itemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.ItemPool> dbSet)
                return dbSet.FindAsync(itemID);

            var task = queryable.FirstOrDefaultAsync(q => q.ItemID == itemID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.ItemPool>(task);
        }

        #endregion

    }
}
