using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefMonsterAssignedItemDropExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefMonsterAssignedItemDrop> ByRefItemID(this IQueryable<VsroShard.Shard_Repository.Entities.RefMonsterAssignedItemDrop> queryable, int refItemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.RefItemID == refItemID);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefMonsterAssignedItemDrop> ByRefMonsterID(this IQueryable<VsroShard.Shard_Repository.Entities.RefMonsterAssignedItemDrop> queryable, int refMonsterID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.RefMonsterID == refMonsterID);
        }

        #endregion

    }
}
