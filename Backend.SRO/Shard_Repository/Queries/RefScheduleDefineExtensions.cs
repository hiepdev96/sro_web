using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefScheduleDefineExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefScheduleDefine GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefScheduleDefine> queryable, int scheduleDefineIdx)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefScheduleDefine> dbSet)
                return dbSet.Find(scheduleDefineIdx);

            return queryable.FirstOrDefault(q => q.ScheduleDefineIdx == scheduleDefineIdx);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefScheduleDefine> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefScheduleDefine> queryable, int scheduleDefineIdx)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefScheduleDefine> dbSet)
                return dbSet.FindAsync(scheduleDefineIdx);

            var task = queryable.FirstOrDefaultAsync(q => q.ScheduleDefineIdx == scheduleDefineIdx);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefScheduleDefine>(task);
        }

        #endregion

    }
}
