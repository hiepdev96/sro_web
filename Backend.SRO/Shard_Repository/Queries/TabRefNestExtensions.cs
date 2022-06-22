using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class TabRefNestExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.TabRefNest GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.TabRefNest> queryable, int dwNestID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TabRefNest> dbSet)
                return dbSet.Find(dwNestID);

            return queryable.FirstOrDefault(q => q.DwNestID == dwNestID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.TabRefNest> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.TabRefNest> queryable, int dwNestID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TabRefNest> dbSet)
                return dbSet.FindAsync(dwNestID);

            var task = queryable.FirstOrDefaultAsync(q => q.DwNestID == dwNestID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.TabRefNest>(task);
        }

        #endregion

    }
}
