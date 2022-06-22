using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefRegionExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefRegion GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefRegion> queryable, short wRegionID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefRegion> dbSet)
                return dbSet.Find(wRegionID);

            return queryable.FirstOrDefault(q => q.WRegionID == wRegionID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefRegion> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefRegion> queryable, short wRegionID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefRegion> dbSet)
                return dbSet.FindAsync(wRegionID);

            var task = queryable.FirstOrDefaultAsync(q => q.WRegionID == wRegionID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefRegion>(task);
        }

        #endregion

    }
}
