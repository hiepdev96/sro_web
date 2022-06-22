using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefMonsterAssignedItemRndDropExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefMonsterAssignedItemRndDrop> ByRefMonsterID(this IQueryable<VsroShard.Shard_Repository.Entities.RefMonsterAssignedItemRndDrop> queryable, int refMonsterID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.RefMonsterID == refMonsterID);
        }

        #endregion

    }
}
