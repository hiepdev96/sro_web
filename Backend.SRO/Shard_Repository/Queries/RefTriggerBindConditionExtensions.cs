using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefTriggerBindConditionExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefTriggerBindCondition GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindCondition> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefTriggerBindCondition> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefTriggerBindCondition> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindCondition> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefTriggerBindCondition> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefTriggerBindCondition>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindCondition> ByTriggerConditionID(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindCondition> queryable, int triggerConditionID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.TriggerConditionID == triggerConditionID);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindCondition> ByTriggerID(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindCondition> queryable, int triggerID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.TriggerID == triggerID);
        }

        #endregion

    }
}
