using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class MemoExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.Memo> ByCharID(this IQueryable<VsroShard.Shard_Repository.Entities.Memo> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.CharID == charID);
        }

        public static VsroShard.Shard_Repository.Entities.Memo GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.Memo> queryable, long id64)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.Memo> dbSet)
                return dbSet.Find(id64);

            return queryable.FirstOrDefault(q => q.Id64 == id64);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.Memo> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.Memo> queryable, long id64)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.Memo> dbSet)
                return dbSet.FindAsync(id64);

            var task = queryable.FirstOrDefaultAsync(q => q.Id64 == id64);
            return new ValueTask<VsroShard.Shard_Repository.Entities.Memo>(task);
        }

        #endregion

    }
}
