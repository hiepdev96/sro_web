using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class UserExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.User GetByCharID(this IQueryable<VsroShard.Shard_Repository.Entities.User> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.FirstOrDefault(q => q.CharID == charID);
        }

        public static Task<VsroShard.Shard_Repository.Entities.User> GetByCharIDAsync(this IQueryable<VsroShard.Shard_Repository.Entities.User> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.FirstOrDefaultAsync(q => q.CharID == charID);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.User> ByUserJID(this IQueryable<VsroShard.Shard_Repository.Entities.User> queryable, int userJID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.UserJID == userJID);
        }

        #endregion

    }
}
