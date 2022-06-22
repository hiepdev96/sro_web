using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefTriggerBindActionExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefTriggerBindAction GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindAction> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefTriggerBindAction> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefTriggerBindAction> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindAction> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefTriggerBindAction> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefTriggerBindAction>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindAction> ByTriggerActionID(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindAction> queryable, int triggerActionID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.TriggerActionID == triggerActionID);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindAction> ByTriggerID(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindAction> queryable, int triggerID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.TriggerID == triggerID);
        }

        #endregion

    }
}
