using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefSiegeLvlSummonMonsterExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefSiegeLvlSummonMonster GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeLvlSummonMonster> queryable, int refObjID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeLvlSummonMonster> dbSet)
                return dbSet.Find(refObjID);

            return queryable.FirstOrDefault(q => q.RefObjID == refObjID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeLvlSummonMonster> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeLvlSummonMonster> queryable, int refObjID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeLvlSummonMonster> dbSet)
                return dbSet.FindAsync(refObjID);

            var task = queryable.FirstOrDefaultAsync(q => q.RefObjID == refObjID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeLvlSummonMonster>(task);
        }

        #endregion

    }
}
