using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class SiegeFortressExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.SiegeFortress GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortress> queryable, int fortressID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.SiegeFortress> dbSet)
                return dbSet.Find(fortressID);

            return queryable.FirstOrDefault(q => q.FortressID == fortressID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.SiegeFortress> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortress> queryable, int fortressID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.SiegeFortress> dbSet)
                return dbSet.FindAsync(fortressID);

            var task = queryable.FirstOrDefaultAsync(q => q.FortressID == fortressID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.SiegeFortress>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortress> ByGuildID(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortress> queryable, int guildID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.GuildID == guildID);
        }

        #endregion

    }
}
