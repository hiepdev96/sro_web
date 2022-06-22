using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class ChestExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.Chest> ByItemID(this IQueryable<VsroShard.Shard_Repository.Entities.Chest> queryable, long? itemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => (q.ItemID == itemID || (itemID == null && q.ItemID == null)));
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.Chest> ByUserJID(this IQueryable<VsroShard.Shard_Repository.Entities.Chest> queryable, int userJID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.UserJID == userJID);
        }

        public static VsroShard.Shard_Repository.Entities.Chest GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.Chest> queryable, int userJID, byte slot)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.Chest> dbSet)
                return dbSet.Find(userJID, slot);

            return queryable.FirstOrDefault(q => q.UserJID == userJID
                && q.Slot == slot);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.Chest> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.Chest> queryable, int userJID, byte slot)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.Chest> dbSet)
                return dbSet.FindAsync(userJID, slot);

            var task = queryable.FirstOrDefaultAsync(q => q.UserJID == userJID
                && q.Slot == slot);
            return new ValueTask<VsroShard.Shard_Repository.Entities.Chest>(task);
        }

        #endregion

    }
}
