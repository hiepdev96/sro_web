using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class AccountJIDExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.AccountJID GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.AccountJID> queryable, string accountID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.AccountJID> dbSet)
                return dbSet.Find(accountID);

            return queryable.FirstOrDefault(q => q.AccountID == accountID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.AccountJID> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.AccountJID> queryable, string accountID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.AccountJID> dbSet)
                return dbSet.FindAsync(accountID);

            var task = queryable.FirstOrDefaultAsync(q => q.AccountID == accountID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.AccountJID>(task);
        }

        #endregion

    }
}
