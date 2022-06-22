using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class ServerEventRewardExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.ServerEventReward> ByRewardID(this IQueryable<VsroShard.Shard_Repository.Entities.ServerEventReward> queryable, int rewardID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.RewardID == rewardID);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.ServerEventReward> ByServerEventID(this IQueryable<VsroShard.Shard_Repository.Entities.ServerEventReward> queryable, int serverEventID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.ServerEventID == serverEventID);
        }

        #endregion

    }
}
