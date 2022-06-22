using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class SiegeFortressStoneStateExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressStoneState> ByFortressID(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressStoneState> queryable, int fortressID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.FortressID == fortressID);
        }

        #endregion

    }
}
