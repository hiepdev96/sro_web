using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class TabRefRankingHunterContributionExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.TabRefRankingHunterContribution GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.TabRefRankingHunterContribution> queryable, byte rank)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TabRefRankingHunterContribution> dbSet)
                return dbSet.Find(rank);

            return queryable.FirstOrDefault(q => q.Rank == rank);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.TabRefRankingHunterContribution> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.TabRefRankingHunterContribution> queryable, byte rank)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TabRefRankingHunterContribution> dbSet)
                return dbSet.FindAsync(rank);

            var task = queryable.FirstOrDefaultAsync(q => q.Rank == rank);
            return new ValueTask<VsroShard.Shard_Repository.Entities.TabRefRankingHunterContribution>(task);
        }

        #endregion

    }
}
