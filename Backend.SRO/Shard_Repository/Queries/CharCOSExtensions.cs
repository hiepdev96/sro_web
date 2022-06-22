using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class CharCOSExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.CharCOS> ByCharName(this IQueryable<VsroShard.Shard_Repository.Entities.CharCOS> queryable, string charName)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => (q.CharName == charName || (charName == null && q.CharName == null)));
        }

        public static VsroShard.Shard_Repository.Entities.CharCOS GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.CharCOS> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharCOS> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.CharCOS> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.CharCOS> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharCOS> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroShard.Shard_Repository.Entities.CharCOS>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.CharCOS> ByOwnerCharID(this IQueryable<VsroShard.Shard_Repository.Entities.CharCOS> queryable, int ownerCharID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.OwnerCharID == ownerCharID);
        }

        #endregion

    }
}
