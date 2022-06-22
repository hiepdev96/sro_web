using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class UserOldExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.UserOld GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.UserOld> queryable, int userJID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.UserOld> dbSet)
                return dbSet.Find(userJID);

            return queryable.FirstOrDefault(q => q.UserJID == userJID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.UserOld> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.UserOld> queryable, int userJID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.UserOld> dbSet)
                return dbSet.FindAsync(userJID);

            var task = queryable.FirstOrDefaultAsync(q => q.UserJID == userJID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.UserOld>(task);
        }

        #endregion

    }
}
