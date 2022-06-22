using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class InventoryExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.Inventory> ByCharID(this IQueryable<VsroShard.Shard_Repository.Entities.Inventory> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.CharID == charID);
        }

        public static VsroShard.Shard_Repository.Entities.Inventory GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.Inventory> queryable, int charID, byte slot)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.Inventory> dbSet)
                return dbSet.Find(charID, slot);

            return queryable.FirstOrDefault(q => q.CharID == charID
                && q.Slot == slot);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.Inventory> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.Inventory> queryable, int charID, byte slot)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.Inventory> dbSet)
                return dbSet.FindAsync(charID, slot);

            var task = queryable.FirstOrDefaultAsync(q => q.CharID == charID
                && q.Slot == slot);
            return new ValueTask<VsroShard.Shard_Repository.Entities.Inventory>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.Inventory> ByItemID(this IQueryable<VsroShard.Shard_Repository.Entities.Inventory> queryable, long itemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.ItemID == itemID);
        }

        #endregion

    }
}
