using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefSiegeBlessBuffExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff> queryable, int blessID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff> dbSet)
                return dbSet.Find(blessID);

            return queryable.FirstOrDefault(q => q.BlessID == blessID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff> queryable, int blessID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff> dbSet)
                return dbSet.FindAsync(blessID);

            var task = queryable.FirstOrDefaultAsync(q => q.BlessID == blessID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff> ByFortressID(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff> queryable, int fortressID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.FortressID == fortressID);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff> ByRefBlessBuffID(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeBlessBuff> queryable, int refBlessBuffID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.RefBlessBuffID == refBlessBuffID);
        }

        #endregion

    }
}
