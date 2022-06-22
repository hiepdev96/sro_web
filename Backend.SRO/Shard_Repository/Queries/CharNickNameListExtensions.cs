using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class CharNickNameListExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.CharNickNameList> ByCharID(this IQueryable<VsroShard.Shard_Repository.Entities.CharNickNameList> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.CharID == charID);
        }

        public static VsroShard.Shard_Repository.Entities.CharNickNameList GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.CharNickNameList> queryable, string nickName16, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharNickNameList> dbSet)
                return dbSet.Find(nickName16, charID);

            return queryable.FirstOrDefault(q => q.NickName16 == nickName16
                && q.CharID == charID);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.CharNickNameList> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.CharNickNameList> queryable, string nickName16, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharNickNameList> dbSet)
                return dbSet.FindAsync(nickName16, charID);

            var task = queryable.FirstOrDefaultAsync(q => q.NickName16 == nickName16
                && q.CharID == charID);
            return new ValueTask<VsroShard.Shard_Repository.Entities.CharNickNameList>(task);
        }

        #endregion

    }
}
