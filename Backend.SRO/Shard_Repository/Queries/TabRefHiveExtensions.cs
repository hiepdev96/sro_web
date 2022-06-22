using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class TabRefHiveExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.TabRefHive GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.TabRefHive> queryable, int dwHiveID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TabRefHive> dbSet)
                return dbSet.Find(dwHiveID);

            return queryable.FirstOrDefault(q => q.DwHiveID == dwHiveID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.TabRefHive> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.TabRefHive> queryable, int dwHiveID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TabRefHive> dbSet)
                return dbSet.FindAsync(dwHiveID);

            var task = queryable.FirstOrDefaultAsync(q => q.DwHiveID == dwHiveID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.TabRefHive>(task);
        }

        #endregion

    }
}
