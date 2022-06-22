using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class SiegeFortressBattleRecordExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressBattleRecord> ByFortressID(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressBattleRecord> queryable, int fortressID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.FortressID == fortressID);
        }

        public static VsroShard.Shard_Repository.Entities.SiegeFortressBattleRecord GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressBattleRecord> queryable, int fortressID, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.SiegeFortressBattleRecord> dbSet)
                return dbSet.Find(fortressID, charID);

            return queryable.FirstOrDefault(q => q.FortressID == fortressID
                && q.CharID == charID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.SiegeFortressBattleRecord> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressBattleRecord> queryable, int fortressID, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.SiegeFortressBattleRecord> dbSet)
                return dbSet.FindAsync(fortressID, charID);

            var task = queryable.FirstOrDefaultAsync(q => q.FortressID == fortressID
                && q.CharID == charID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.SiegeFortressBattleRecord>(task);
        }

        #endregion

    }
}
