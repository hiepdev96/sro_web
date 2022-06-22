using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefTriggerCategoryBindTriggerExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefTriggerCategoryBindTrigger GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerCategoryBindTrigger> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefTriggerCategoryBindTrigger> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefTriggerCategoryBindTrigger> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerCategoryBindTrigger> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefTriggerCategoryBindTrigger> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefTriggerCategoryBindTrigger>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerCategoryBindTrigger> ByTriggerID(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerCategoryBindTrigger> queryable, int triggerID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.TriggerID == triggerID);
        }

        #endregion

    }
}
