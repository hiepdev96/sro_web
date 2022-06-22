using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefPackageItemExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefPackageItem> ByCountry(this IQueryable<VsroShard.Shard_Repository.Entities.RefPackageItem> queryable, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Country == country);
        }

        public static VsroShard.Shard_Repository.Entities.RefPackageItem GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefPackageItem> queryable, int id, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefPackageItem> dbSet)
                return dbSet.Find(id, country);

            return queryable.FirstOrDefault(q => q.Id == id
                && q.Country == country);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefPackageItem> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefPackageItem> queryable, int id, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefPackageItem> dbSet)
                return dbSet.FindAsync(id, country);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id
                && q.Country == country);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefPackageItem>(task);
        }

        #endregion

    }
}
