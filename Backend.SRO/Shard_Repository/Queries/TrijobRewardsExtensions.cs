using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class TrijobRewardsExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.TrijobRewards GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.TrijobRewards> queryable, byte jobType)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TrijobRewards> dbSet)
                return dbSet.Find(jobType);

            return queryable.FirstOrDefault(q => q.JobType == jobType);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.TrijobRewards> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.TrijobRewards> queryable, byte jobType)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TrijobRewards> dbSet)
                return dbSet.FindAsync(jobType);

            var task = queryable.FirstOrDefaultAsync(q => q.JobType == jobType);
            return new ValueTask<VsroShard.Shard_Repository.Entities.TrijobRewards>(task);
        }

        #endregion

    }
}
