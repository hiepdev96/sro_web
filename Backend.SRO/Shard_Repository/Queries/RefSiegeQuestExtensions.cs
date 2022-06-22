using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefSiegeQuestExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefSiegeQuest GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeQuest> queryable, int questID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeQuest> dbSet)
                return dbSet.Find(questID);

            return queryable.FirstOrDefault(q => q.QuestID == questID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeQuest> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeQuest> queryable, int questID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefSiegeQuest> dbSet)
                return dbSet.FindAsync(questID);

            var task = queryable.FirstOrDefaultAsync(q => q.QuestID == questID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefSiegeQuest>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeQuest> ByQuestName(this IQueryable<VsroShard.Shard_Repository.Entities.RefSiegeQuest> queryable, string questName)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.QuestName == questName);
        }

        #endregion

    }
}
