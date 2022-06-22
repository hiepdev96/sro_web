using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefRentItemExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefRentItem GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefRentItem> queryable, string rentCodeName, int refItemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefRentItem> dbSet)
                return dbSet.Find(rentCodeName, refItemID);

            return queryable.FirstOrDefault(q => q.RentCodeName == rentCodeName
                && q.RefItemID == refItemID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefRentItem> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefRentItem> queryable, string rentCodeName, int refItemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefRentItem> dbSet)
                return dbSet.FindAsync(rentCodeName, refItemID);

            var task = queryable.FirstOrDefaultAsync(q => q.RentCodeName == rentCodeName
                && q.RefItemID == refItemID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefRentItem>(task);
        }

        #endregion

    }
}
