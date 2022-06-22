using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class CharSkillExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.CharSkill> ByCharID(this IQueryable<VsroShard.Shard_Repository.Entities.CharSkill> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.CharID == charID);
        }

        public static VsroShard.Shard_Repository.Entities.CharSkill GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.CharSkill> queryable, int charID, int skillID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharSkill> dbSet)
                return dbSet.Find(charID, skillID);

            return queryable.FirstOrDefault(q => q.CharID == charID
                && q.SkillID == skillID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.CharSkill> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.CharSkill> queryable, int charID, int skillID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharSkill> dbSet)
                return dbSet.FindAsync(charID, skillID);

            var task = queryable.FirstOrDefaultAsync(q => q.CharID == charID
                && q.SkillID == skillID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.CharSkill>(task);
        }

        #endregion

    }
}
