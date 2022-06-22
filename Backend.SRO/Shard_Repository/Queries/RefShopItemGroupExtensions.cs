using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefShopItemGroupExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefShopItemGroup GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefShopItemGroup> queryable, int groupID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefShopItemGroup> dbSet)
                return dbSet.Find(groupID);

            return queryable.FirstOrDefault(q => q.GroupID == groupID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefShopItemGroup> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefShopItemGroup> queryable, int groupID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefShopItemGroup> dbSet)
                return dbSet.FindAsync(groupID);

            var task = queryable.FirstOrDefaultAsync(q => q.GroupID == groupID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefShopItemGroup>(task);
        }

        #endregion

    }
}
