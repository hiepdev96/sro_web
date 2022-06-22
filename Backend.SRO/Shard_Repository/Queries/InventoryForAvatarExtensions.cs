using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class InventoryForAvatarExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.InventoryForAvatar> ByCharID(this IQueryable<VsroShard.Shard_Repository.Entities.InventoryForAvatar> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.CharID == charID);
        }

        public static VsroShard.Shard_Repository.Entities.InventoryForAvatar GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.InventoryForAvatar> queryable, int charID, byte slot)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.InventoryForAvatar> dbSet)
                return dbSet.Find(charID, slot);

            return queryable.FirstOrDefault(q => q.CharID == charID
                && q.Slot == slot);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.InventoryForAvatar> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.InventoryForAvatar> queryable, int charID, byte slot)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.InventoryForAvatar> dbSet)
                return dbSet.FindAsync(charID, slot);

            var task = queryable.FirstOrDefaultAsync(q => q.CharID == charID
                && q.Slot == slot);
            return new ValueTask<VsroShard.Shard_Repository.Entities.InventoryForAvatar>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.InventoryForAvatar> ByItemID(this IQueryable<VsroShard.Shard_Repository.Entities.InventoryForAvatar> queryable, long itemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.ItemID == itemID);
        }

        #endregion

    }
}
