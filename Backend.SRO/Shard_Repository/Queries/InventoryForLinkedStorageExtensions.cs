using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class InventoryForLinkedStorageExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.InventoryForLinkedStorage> ByItemID(this IQueryable<VsroShard.Shard_Repository.Entities.InventoryForLinkedStorage> queryable, long itemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.ItemID == itemID);
        }

        public static VsroShard.Shard_Repository.Entities.InventoryForLinkedStorage GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.InventoryForLinkedStorage> queryable, long linkedItemID, byte slot)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.InventoryForLinkedStorage> dbSet)
                return dbSet.Find(linkedItemID, slot);

            return queryable.FirstOrDefault(q => q.LinkedItemID == linkedItemID
                && q.Slot == slot);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.InventoryForLinkedStorage> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.InventoryForLinkedStorage> queryable, long linkedItemID, byte slot)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.InventoryForLinkedStorage> dbSet)
                return dbSet.FindAsync(linkedItemID, slot);

            var task = queryable.FirstOrDefaultAsync(q => q.LinkedItemID == linkedItemID
                && q.Slot == slot);
            return new ValueTask<VsroShard.Shard_Repository.Entities.InventoryForLinkedStorage>(task);
        }

        #endregion

    }
}
