using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefMagicOptExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.RefMagicOpt GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefMagicOpt> queryable, short id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefMagicOpt> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefMagicOpt> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefMagicOpt> queryable, short id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefMagicOpt> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefMagicOpt>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefMagicOpt> ByMLevel(this IQueryable<VsroShard.Shard_Repository.Entities.RefMagicOpt> queryable, int mLevel)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.MLevel == mLevel);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.RefMagicOpt> ByMOptName128(this IQueryable<VsroShard.Shard_Repository.Entities.RefMagicOpt> queryable, string mOptName128)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.MOptName128 == mOptName128);
        }

        #endregion

    }
}
