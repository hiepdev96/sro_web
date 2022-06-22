using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class StaticAvatarExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.StaticAvatar GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.StaticAvatar> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.StaticAvatar> dbSet)
                return dbSet.Find(charID);

            return queryable.FirstOrDefault(q => q.CharID == charID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.StaticAvatar> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.StaticAvatar> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.StaticAvatar> dbSet)
                return dbSet.FindAsync(charID);

            var task = queryable.FirstOrDefaultAsync(q => q.CharID == charID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.StaticAvatar>(task);
        }

        #endregion

    }
}
