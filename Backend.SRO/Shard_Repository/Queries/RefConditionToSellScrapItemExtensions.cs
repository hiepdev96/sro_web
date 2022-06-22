using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefConditionToSellScrapItemExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefConditionToSellScrapItem GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefConditionToSellScrapItem> queryable, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefConditionToSellScrapItem> dbSet)
                return dbSet.Find(country);

            return queryable.FirstOrDefault(q => q.Country == country);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefConditionToSellScrapItem> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefConditionToSellScrapItem> queryable, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefConditionToSellScrapItem> dbSet)
                return dbSet.FindAsync(country);

            var task = queryable.FirstOrDefaultAsync(q => q.Country == country);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefConditionToSellScrapItem>(task);
        }

        #endregion

    }
}
