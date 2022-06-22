using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class InvCOSExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.InvCOS> ByCosid(this IQueryable<VsroShard.Shard_Repository.Entities.InvCOS> queryable, int cosid)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Cosid == cosid);
        }

        public static VsroShard.Shard_Repository.Entities.InvCOS GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.InvCOS> queryable, int cosid, byte slot)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.InvCOS> dbSet)
                return dbSet.Find(cosid, slot);

            return queryable.FirstOrDefault(q => q.Cosid == cosid
                && q.Slot == slot);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.InvCOS> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.InvCOS> queryable, int cosid, byte slot)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.InvCOS> dbSet)
                return dbSet.FindAsync(cosid, slot);

            var task = queryable.FirstOrDefaultAsync(q => q.Cosid == cosid
                && q.Slot == slot);
            return new ValueTask<VsroShard.Shard_Repository.Entities.InvCOS>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.InvCOS> ByItemID(this IQueryable<VsroShard.Shard_Repository.Entities.InvCOS> queryable, long? itemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => (q.ItemID == itemID || (itemID == null && q.ItemID == null)));
        }

        #endregion

    }
}
