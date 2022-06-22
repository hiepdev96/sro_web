using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefSiegeQuestRewardExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeQuestReward> ByQuestID(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeQuestReward> queryable, int questID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.QuestID == questID);
        }

        #endregion

    }
}
