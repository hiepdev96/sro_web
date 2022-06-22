using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class ScheduleExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.Schedule GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.Schedule> queryable, int scheduleIdx)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.Schedule> dbSet)
                return dbSet.Find(scheduleIdx);

            return queryable.FirstOrDefault(q => q.ScheduleIdx == scheduleIdx);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.Schedule> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.Schedule> queryable, int scheduleIdx)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.Schedule> dbSet)
                return dbSet.FindAsync(scheduleIdx);

            var task = queryable.FirstOrDefaultAsync(q => q.ScheduleIdx == scheduleIdx);
            return new ValueTask<VsroShard.Shard_Repository.Entities.Schedule>(task);
        }

        #endregion

    }
}
