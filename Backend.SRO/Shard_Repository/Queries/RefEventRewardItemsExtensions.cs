using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefEventRewardItemsExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefEventRewardItems> ByEventID(this IQueryable<VsroShard.Shard_Repository.Entities.RefEventRewardItems> queryable, int eventID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.EventID == eventID);
        }

        #endregion

    }
}
