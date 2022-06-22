using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class SiegeFortressItemForgeExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressItemForge> ByFortressID(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressItemForge> queryable, int fortressID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.FortressID == fortressID);
        }

        public static VsroShard.Shard_Repository.Entities.SiegeFortressItemForge GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressItemForge> queryable, int fortressID, int itemRefID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.SiegeFortressItemForge> dbSet)
                return dbSet.Find(fortressID, itemRefID);

            return queryable.FirstOrDefault(q => q.FortressID == fortressID
                && q.ItemRefID == itemRefID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.SiegeFortressItemForge> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.SiegeFortressItemForge> queryable, int fortressID, int itemRefID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.SiegeFortressItemForge> dbSet)
                return dbSet.FindAsync(fortressID, itemRefID);

            var task = queryable.FirstOrDefaultAsync(q => q.FortressID == fortressID
                && q.ItemRefID == itemRefID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.SiegeFortressItemForge>(task);
        }

        #endregion

    }
}
