using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class GuildChestExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.GuildChest> ByGuildID(this IQueryable<VsroShard.Shard_Repository.Entities.GuildChest> queryable, int guildID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.GuildID == guildID);
        }

        public static VsroShard.Shard_Repository.Entities.GuildChest GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.GuildChest> queryable, int guildID, byte slot)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.GuildChest> dbSet)
                return dbSet.Find(guildID, slot);

            return queryable.FirstOrDefault(q => q.GuildID == guildID
                && q.Slot == slot);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.GuildChest> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.GuildChest> queryable, int guildID, byte slot)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.GuildChest> dbSet)
                return dbSet.FindAsync(guildID, slot);

            var task = queryable.FirstOrDefaultAsync(q => q.GuildID == guildID
                && q.Slot == slot);
            return new ValueTask<VsroShard.Shard_Repository.Entities.GuildChest>(task);
        }

        #endregion

    }
}
