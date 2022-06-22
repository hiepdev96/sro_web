using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class SiegeFortressRequestExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressRequest> ByFortressID(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressRequest> queryable, int fortressID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.FortressID == fortressID);
        }

        public static VsroShard.Shard_Repository.Entities.SiegeFortressRequest GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressRequest> queryable, int fortressID, int guildID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.SiegeFortressRequest> dbSet)
                return dbSet.Find(fortressID, guildID);

            return queryable.FirstOrDefault(q => q.FortressID == fortressID
                && q.GuildID == guildID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.SiegeFortressRequest> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressRequest> queryable, int fortressID, int guildID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.SiegeFortressRequest> dbSet)
                return dbSet.FindAsync(fortressID, guildID);

            var task = queryable.FirstOrDefaultAsync(q => q.FortressID == fortressID
                && q.GuildID == guildID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.SiegeFortressRequest>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressRequest> ByGuildID(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressRequest> queryable, int guildID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.GuildID == guildID);
        }

        #endregion

    }
}
