using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefSiegeFortressBattleRankExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefSiegeFortressBattleRank GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeFortressBattleRank> queryable, byte rankLvl)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeFortressBattleRank> dbSet)
                return dbSet.Find(rankLvl);

            return queryable.FirstOrDefault(q => q.RankLvl == rankLvl);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeFortressBattleRank> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeFortressBattleRank> queryable, byte rankLvl)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeFortressBattleRank> dbSet)
                return dbSet.FindAsync(rankLvl);

            var task = queryable.FirstOrDefaultAsync(q => q.RankLvl == rankLvl);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeFortressBattleRank>(task);
        }

        #endregion

    }
}
