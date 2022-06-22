using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefSiegeFortressGuardExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefSiegeFortressGuard GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeFortressGuard> queryable, int fortressID, int guardRefObjID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeFortressGuard> dbSet)
                return dbSet.Find(fortressID, guardRefObjID);

            return queryable.FirstOrDefault(q => q.FortressID == fortressID
                && q.GuardRefObjID == guardRefObjID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeFortressGuard> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeFortressGuard> queryable, int fortressID, int guardRefObjID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeFortressGuard> dbSet)
                return dbSet.FindAsync(fortressID, guardRefObjID);

            var task = queryable.FirstOrDefaultAsync(q => q.FortressID == fortressID
                && q.GuardRefObjID == guardRefObjID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeFortressGuard>(task);
        }

        #endregion

    }
}
