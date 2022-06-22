using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefSiegeDungeonExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefSiegeDungeon GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeDungeon> queryable, int fortressID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeDungeon> dbSet)
                return dbSet.Find(fortressID);

            return queryable.FirstOrDefault(q => q.FortressID == fortressID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeDungeon> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeDungeon> queryable, int fortressID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeDungeon> dbSet)
                return dbSet.FindAsync(fortressID);

            var task = queryable.FirstOrDefaultAsync(q => q.FortressID == fortressID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeDungeon>(task);
        }

        #endregion

    }
}
