using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class CharQuestExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.CharQuest GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.CharQuest> queryable, int charID, int questID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharQuest> dbSet)
                return dbSet.Find(charID, questID);

            return queryable.FirstOrDefault(q => q.CharID == charID
                && q.QuestID == questID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.CharQuest> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.CharQuest> queryable, int charID, int questID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharQuest> dbSet)
                return dbSet.FindAsync(charID, questID);

            var task = queryable.FirstOrDefaultAsync(q => q.CharID == charID
                && q.QuestID == questID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.CharQuest>(task);
        }

        #endregion

    }
}
