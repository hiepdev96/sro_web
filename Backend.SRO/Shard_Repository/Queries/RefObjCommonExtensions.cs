using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefObjCommonExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefObjCommon> ByCodeName128(this IQueryable<VsroShard.Shard_Repository.Entities.RefObjCommon> queryable, string codeName128)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.CodeName128 == codeName128);
        }

        public static VsroShard.Shard_Repository.Entities.RefObjCommon GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefObjCommon> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefObjCommon> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.RefObjCommon> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefObjCommon> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefObjCommon> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroShard.Shard_Repository.Entities.RefObjCommon>(task);
        }

        #endregion

    }
}
