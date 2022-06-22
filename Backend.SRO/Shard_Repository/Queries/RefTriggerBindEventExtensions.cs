using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefTriggerBindEventExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefTriggerBindEvent GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindEvent> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefTriggerBindEvent> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefTriggerBindEvent> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindEvent> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefTriggerBindEvent> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefTriggerBindEvent>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindEvent> ByTriggerEventID(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindEvent> queryable, int triggerEventID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.TriggerEventID == triggerEventID);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindEvent> ByTriggerID(this IQueryable<VsroShard.Shard_Repository.Entities.RefTriggerBindEvent> queryable, int triggerID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.TriggerID == triggerID);
        }

        #endregion

    }
}
