using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class UserBalanceNhatExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.UserBalanceNhat GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.UserBalanceNhat> queryable, int jid)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.UserBalanceNhat> dbSet)
                return dbSet.Find(jid);

            return queryable.FirstOrDefault(q => q.Jid == jid);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.UserBalanceNhat> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.UserBalanceNhat> queryable, int jid)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.UserBalanceNhat> dbSet)
                return dbSet.FindAsync(jid);

            var task = queryable.FirstOrDefaultAsync(q => q.Jid == jid);
            return new ValueTask<VsroShard.Shard_Repository.Entities.UserBalanceNhat>(task);
        }

        #endregion

    }
}
