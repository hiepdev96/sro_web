using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefObjCharExtraSkillExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefObjCharExtraSkill GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefObjCharExtraSkill> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefObjCharExtraSkill> dbSet)
                return dbSet.Find(charID);

            return queryable.FirstOrDefault(q => q.CharID == charID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefObjCharExtraSkill> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefObjCharExtraSkill> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefObjCharExtraSkill> dbSet)
                return dbSet.FindAsync(charID);

            var task = queryable.FirstOrDefaultAsync(q => q.CharID == charID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefObjCharExtraSkill>(task);
        }

        #endregion

    }
}
