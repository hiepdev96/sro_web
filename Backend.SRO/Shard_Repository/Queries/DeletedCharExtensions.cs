using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class DeletedCharExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.DeletedChar GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.DeletedChar> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.DeletedChar> dbSet)
                return dbSet.Find(charID);

            return queryable.FirstOrDefault(q => q.CharID == charID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.DeletedChar> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.DeletedChar> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.DeletedChar> dbSet)
                return dbSet.FindAsync(charID);

            var task = queryable.FirstOrDefaultAsync(q => q.CharID == charID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.DeletedChar>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.DeletedChar> ByUserJID(this IQueryable<VsroShard.Shard_Repository.Entities.DeletedChar> queryable, int userJID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.UserJID == userJID);
        }

        #endregion

    }
}
