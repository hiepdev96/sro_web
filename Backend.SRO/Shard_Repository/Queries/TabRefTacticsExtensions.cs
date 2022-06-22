using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class TabRefTacticsExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.TabRefTactics GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.TabRefTactics> queryable, int dwTacticsID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TabRefTactics> dbSet)
                return dbSet.Find(dwTacticsID);

            return queryable.FirstOrDefault(q => q.DwTacticsID == dwTacticsID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.TabRefTactics> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.TabRefTactics> queryable, int dwTacticsID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TabRefTactics> dbSet)
                return dbSet.FindAsync(dwTacticsID);

            var task = queryable.FirstOrDefaultAsync(q => q.DwTacticsID == dwTacticsID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.TabRefTactics>(task);
        }

        #endregion

    }
}
