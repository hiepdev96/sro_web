using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefConditionToSellPackageItemExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefConditionToSellPackageItem GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefConditionToSellPackageItem> queryable, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefConditionToSellPackageItem> dbSet)
                return dbSet.Find(country);

            return queryable.FirstOrDefault(q => q.Country == country);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefConditionToSellPackageItem> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefConditionToSellPackageItem> queryable, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefConditionToSellPackageItem> dbSet)
                return dbSet.FindAsync(country);

            var task = queryable.FirstOrDefaultAsync(q => q.Country == country);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefConditionToSellPackageItem>(task);
        }

        #endregion

    }
}
