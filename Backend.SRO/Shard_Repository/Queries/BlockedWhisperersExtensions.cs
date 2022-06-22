using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class BlockedWhisperersExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.BlockedWhisperers GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.BlockedWhisperers> queryable, int ownerID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.BlockedWhisperers> dbSet)
                return dbSet.Find(ownerID);

            return queryable.FirstOrDefault(q => q.OwnerID == ownerID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.BlockedWhisperers> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.BlockedWhisperers> queryable, int ownerID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.BlockedWhisperers> dbSet)
                return dbSet.FindAsync(ownerID);

            var task = queryable.FirstOrDefaultAsync(q => q.OwnerID == ownerID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.BlockedWhisperers>(task);
        }

        #endregion

    }
}
