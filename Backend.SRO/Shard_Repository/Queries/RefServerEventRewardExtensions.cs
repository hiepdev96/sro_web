using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefServerEventRewardExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefServerEventReward> ByOwnerServerEventID(this IQueryable<VsroShard.Shard_Repository.Entities.RefServerEventReward> queryable, int ownerServerEventID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.OwnerServerEventID == ownerServerEventID);
        }

        public static VsroShard.Shard_Repository.Entities.RefServerEventReward GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefServerEventReward> queryable, int rewardID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefServerEventReward> dbSet)
                return dbSet.Find(rewardID);

            return queryable.FirstOrDefault(q => q.RewardID == rewardID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefServerEventReward> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefServerEventReward> queryable, int rewardID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefServerEventReward> dbSet)
                return dbSet.FindAsync(rewardID);

            var task = queryable.FirstOrDefaultAsync(q => q.RewardID == rewardID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefServerEventReward>(task);
        }

        #endregion

    }
}
