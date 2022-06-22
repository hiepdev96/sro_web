using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class TabRefSpawnToolVersionExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.TabRefSpawnToolVersion GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.TabRefSpawnToolVersion> queryable, int dwRefDataVersion)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TabRefSpawnToolVersion> dbSet)
                return dbSet.Find(dwRefDataVersion);

            return queryable.FirstOrDefault(q => q.DwRefDataVersion == dwRefDataVersion);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.TabRefSpawnToolVersion> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.TabRefSpawnToolVersion> queryable, int dwRefDataVersion)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TabRefSpawnToolVersion> dbSet)
                return dbSet.FindAsync(dwRefDataVersion);

            var task = queryable.FirstOrDefaultAsync(q => q.DwRefDataVersion == dwRefDataVersion);
            return new ValueTask<VsroShard.Shard_Repository.Entities.TabRefSpawnToolVersion>(task);
        }

        #endregion

    }
}
