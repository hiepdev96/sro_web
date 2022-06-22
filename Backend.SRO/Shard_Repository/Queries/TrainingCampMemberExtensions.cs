using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class TrainingCampMemberExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.TrainingCampMember> ByCampID(this IQueryable<VsroShard.Shard_Repository.Entities.TrainingCampMember> queryable, int campID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.CampID == campID);
        }

        public static VsroShard.Shard_Repository.Entities.TrainingCampMember GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.TrainingCampMember> queryable, int campID, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TrainingCampMember> dbSet)
                return dbSet.Find(campID, charID);

            return queryable.FirstOrDefault(q => q.CampID == campID
                && q.CharID == charID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.TrainingCampMember> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.TrainingCampMember> queryable, int campID, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TrainingCampMember> dbSet)
                return dbSet.FindAsync(campID, charID);

            var task = queryable.FirstOrDefaultAsync(q => q.CampID == campID
                && q.CharID == charID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.TrainingCampMember>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.TrainingCampMember> ByCharID(this IQueryable<VsroShard.Shard_Repository.Entities.TrainingCampMember> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.CharID == charID);
        }

        #endregion

    }
}
