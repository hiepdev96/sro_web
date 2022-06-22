using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class TimedJobExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.TimedJob> ByCharID(this IQueryable<VsroShard.Shard_Repository.Entities.TimedJob> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.CharID == charID);
        }

        public static VsroShard.Shard_Repository.Entities.TimedJob GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.TimedJob> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TimedJob> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.TimedJob> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.TimedJob> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TimedJob> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroShard.Shard_Repository.Entities.TimedJob>(task);
        }

        #endregion

    }
}
