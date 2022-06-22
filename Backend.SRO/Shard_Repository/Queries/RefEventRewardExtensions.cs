using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefEventRewardExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefEventReward GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefEventReward> queryable, int eventID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefEventReward> dbSet)
                return dbSet.Find(eventID);

            return queryable.FirstOrDefault(q => q.EventID == eventID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefEventReward> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefEventReward> queryable, int eventID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefEventReward> dbSet)
                return dbSet.FindAsync(eventID);

            var task = queryable.FirstOrDefaultAsync(q => q.EventID == eventID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefEventReward>(task);
        }

        #endregion

    }
}
