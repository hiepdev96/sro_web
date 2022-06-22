using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class TrainingCampExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.TrainingCamp GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.TrainingCamp> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TrainingCamp> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.TrainingCamp> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.TrainingCamp> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TrainingCamp> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroShard.Shard_Repository.Entities.TrainingCamp>(task);
        }

        #endregion

    }
}
