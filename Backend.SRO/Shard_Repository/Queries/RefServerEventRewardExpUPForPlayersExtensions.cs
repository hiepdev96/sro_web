using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefServerEventRewardExpUPForPlayersExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefServerEventRewardExpUPForPlayers> ByOwnerRewardID(this IQueryable<VsroShard.Shard_Repository.Entities.RefServerEventRewardExpUPForPlayers> queryable, int ownerRewardID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.OwnerRewardID == ownerRewardID);
        }

        #endregion

    }
}
