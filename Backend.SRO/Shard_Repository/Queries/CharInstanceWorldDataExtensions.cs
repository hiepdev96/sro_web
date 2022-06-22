using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class CharInstanceWorldDataExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.CharInstanceWorldData GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.CharInstanceWorldData> queryable, int charID, int worldID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharInstanceWorldData> dbSet)
                return dbSet.Find(charID, worldID);

            return queryable.FirstOrDefault(q => q.CharID == charID
                && q.WorldID == worldID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.CharInstanceWorldData> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.CharInstanceWorldData> queryable, int charID, int worldID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharInstanceWorldData> dbSet)
                return dbSet.FindAsync(charID, worldID);

            var task = queryable.FirstOrDefaultAsync(q => q.CharID == charID
                && q.WorldID == worldID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.CharInstanceWorldData>(task);
        }

        #endregion

    }
}
