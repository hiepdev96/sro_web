using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefGachaNpcMapExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefGachaNpcMap GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefGachaNpcMap> queryable, int npcId)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefGachaNpcMap> dbSet)
                return dbSet.Find(npcId);

            return queryable.FirstOrDefault(q => q.NpcId == npcId);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefGachaNpcMap> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefGachaNpcMap> queryable, int npcId)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefGachaNpcMap> dbSet)
                return dbSet.FindAsync(npcId);

            var task = queryable.FirstOrDefaultAsync(q => q.NpcId == npcId);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefGachaNpcMap>(task);
        }

        #endregion

    }
}
