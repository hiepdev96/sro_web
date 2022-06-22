using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefHWANLevelExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefHWANLevel GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefHWANLevel> queryable, byte hwanLevel)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefHWANLevel> dbSet)
                return dbSet.Find(hwanLevel);

            return queryable.FirstOrDefault(q => q.HwanLevel == hwanLevel);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefHWANLevel> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefHWANLevel> queryable, byte hwanLevel)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefHWANLevel> dbSet)
                return dbSet.FindAsync(hwanLevel);

            var task = queryable.FirstOrDefaultAsync(q => q.HwanLevel == hwanLevel);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefHWANLevel>(task);
        }

        #endregion

    }
}
