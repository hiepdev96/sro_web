using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class CharSkillMasteryExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.CharSkillMastery> ByCharID(this IQueryable<VsroShard.Shard_Repository.Entities.CharSkillMastery> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.CharID == charID);
        }

        public static VsroShard.Shard_Repository.Entities.CharSkillMastery GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.CharSkillMastery> queryable, int charID, int masteryID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharSkillMastery> dbSet)
                return dbSet.Find(charID, masteryID);

            return queryable.FirstOrDefault(q => q.CharID == charID
                && q.MasteryID == masteryID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.CharSkillMastery> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.CharSkillMastery> queryable, int charID, int masteryID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharSkillMastery> dbSet)
                return dbSet.FindAsync(charID, masteryID);

            var task = queryable.FirstOrDefaultAsync(q => q.CharID == charID
                && q.MasteryID == masteryID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.CharSkillMastery>(task);
        }

        #endregion

    }
}
