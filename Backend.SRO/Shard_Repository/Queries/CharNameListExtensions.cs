using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class CharNameListExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.CharNameList GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.CharNameList> queryable, string charName16, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharNameList> dbSet)
                return dbSet.Find(charName16, charID);

            return queryable.FirstOrDefault(q => q.CharName16 == charName16
                && q.CharID == charID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.CharNameList> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.CharNameList> queryable, string charName16, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharNameList> dbSet)
                return dbSet.FindAsync(charName16, charID);

            var task = queryable.FirstOrDefaultAsync(q => q.CharName16 == charName16
                && q.CharID == charID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.CharNameList>(task);
        }

        #endregion

    }
}
