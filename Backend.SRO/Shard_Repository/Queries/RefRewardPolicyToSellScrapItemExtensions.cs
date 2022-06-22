using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefRewardPolicyToSellScrapItemExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefRewardPolicyToSellScrapItem> ByCountry(this IQueryable<VsroShard.Shard_Repository.Entities.RefRewardPolicyToSellScrapItem> queryable, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Country == country);
        }

        #endregion

    }
}
