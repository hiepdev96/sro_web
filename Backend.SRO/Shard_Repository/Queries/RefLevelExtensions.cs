using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefLevelExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefLevel GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefLevel> queryable, byte lvl)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefLevel> dbSet)
                return dbSet.Find(lvl);

            return queryable.FirstOrDefault(q => q.Lvl == lvl);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefLevel> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefLevel> queryable, byte lvl)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefLevel> dbSet)
                return dbSet.FindAsync(lvl);

            var task = queryable.FirstOrDefaultAsync(q => q.Lvl == lvl);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefLevel>(task);
        }

        #endregion

    }
}
