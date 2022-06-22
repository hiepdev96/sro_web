using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class CharExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.Char GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.Char> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.Char> dbSet)
                return dbSet.Find(charID);

            return queryable.FirstOrDefault(q => q.CharID == charID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.Char> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.Char> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.Char> dbSet)
                return dbSet.FindAsync(charID);

            var task = queryable.FirstOrDefaultAsync(q => q.CharID == charID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.Char>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.Char> ByNickName16(this IQueryable<VsroShard.Shard_Repository.Entities.Char> queryable, string nickName16)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.NickName16 == nickName16);
        }

        #endregion

    }
}
