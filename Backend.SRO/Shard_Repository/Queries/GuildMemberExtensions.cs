using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class GuildMemberExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.GuildMember> ByCharID(this IQueryable<VsroShard.Shard_Repository.Entities.GuildMember> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.CharID == charID);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.GuildMember> ByGuildID(this IQueryable<VsroShard.Shard_Repository.Entities.GuildMember> queryable, int guildID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.GuildID == guildID);
        }

        public static VsroShard.Shard_Repository.Entities.GuildMember GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.GuildMember> queryable, int guildID, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.GuildMember> dbSet)
                return dbSet.Find(guildID, charID);

            return queryable.FirstOrDefault(q => q.GuildID == guildID
                && q.CharID == charID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.GuildMember> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.GuildMember> queryable, int guildID, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.GuildMember> dbSet)
                return dbSet.FindAsync(guildID, charID);

            var task = queryable.FirstOrDefaultAsync(q => q.GuildID == guildID
                && q.CharID == charID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.GuildMember>(task);
        }

        #endregion

    }
}
