using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefSiegeFortressItemForgeExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefSiegeFortressItemForge GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeFortressItemForge> queryable, int fortressID, int refItemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeFortressItemForge> dbSet)
                return dbSet.Find(fortressID, refItemID);

            return queryable.FirstOrDefault(q => q.FortressID == fortressID
                && q.RefItemID == refItemID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeFortressItemForge> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeFortressItemForge> queryable, int fortressID, int refItemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeFortressItemForge> dbSet)
                return dbSet.FindAsync(fortressID, refItemID);

            var task = queryable.FirstOrDefaultAsync(q => q.FortressID == fortressID
                && q.RefItemID == refItemID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeFortressItemForge>(task);
        }

        #endregion

    }
}
