using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class TrainingCampHonorRankExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.TrainingCampHonorRank GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.TrainingCampHonorRank> queryable, int ranking)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TrainingCampHonorRank> dbSet)
                return dbSet.Find(ranking);

            return queryable.FirstOrDefault(q => q.Ranking == ranking);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.TrainingCampHonorRank> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.TrainingCampHonorRank> queryable, int ranking)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TrainingCampHonorRank> dbSet)
                return dbSet.FindAsync(ranking);

            var task = queryable.FirstOrDefaultAsync(q => q.Ranking == ranking);
            return new ValueTask<VsroShard.Shard_Repository.Entities.TrainingCampHonorRank>(task);
        }

        #endregion

    }
}
