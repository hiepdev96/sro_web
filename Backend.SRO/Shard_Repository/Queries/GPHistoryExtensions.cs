using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class GPHistoryExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.GPHistory> ByGuildID(this IQueryable<VsroShard.Shard_Repository.Entities.GPHistory> queryable, int guildID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.GuildID == guildID);
        }

        public static VsroShard.Shard_Repository.Entities.GPHistory GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.GPHistory> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.GPHistory> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.GPHistory> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.GPHistory> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.GPHistory> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroShard.Shard_Repository.Entities.GPHistory>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.GPHistory> ByUsedTime(this IQueryable<VsroShard.Shard_Repository.Entities.GPHistory> queryable, DateTime? usedTime)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => (q.UsedTime == usedTime || (usedTime == null && q.UsedTime == null)));
        }

        #endregion

    }
}
