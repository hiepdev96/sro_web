using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class GuildWarExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.GuildWar> ByGuild1(this IQueryable<VsroShard.Shard_Repository.Entities.GuildWar> queryable, int guild1)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Guild1 == guild1);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.GuildWar> ByGuild2(this IQueryable<VsroShard.Shard_Repository.Entities.GuildWar> queryable, int guild2)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Guild2 == guild2);
        }

        public static VsroShard.Shard_Repository.Entities.GuildWar GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.GuildWar> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.GuildWar> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.GuildWar> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.GuildWar> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.GuildWar> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroShard.Shard_Repository.Entities.GuildWar>(task);
        }

        #endregion

    }
}
