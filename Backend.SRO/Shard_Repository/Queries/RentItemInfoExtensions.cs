using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RentItemInfoExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RentItemInfo GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RentItemInfo> queryable, long nItemDBID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RentItemInfo> dbSet)
                return dbSet.Find(nItemDBID);

            return queryable.FirstOrDefault(q => q.NItemDBID == nItemDBID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RentItemInfo> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RentItemInfo> queryable, long nItemDBID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RentItemInfo> dbSet)
                return dbSet.FindAsync(nItemDBID);

            var task = queryable.FirstOrDefaultAsync(q => q.NItemDBID == nItemDBID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RentItemInfo>(task);
        }

        #endregion

    }
}
