using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefDropItemGroupExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefDropItemGroup> ByRefItemID(this IQueryable<VsroShard.Shard_Repository.Entities.RefDropItemGroup> queryable, int refItemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.RefItemID == refItemID);
        }

        #endregion

    }
}
