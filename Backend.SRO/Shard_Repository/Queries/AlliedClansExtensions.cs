using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class AlliedClansExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> ByAlly1(this IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> queryable, int? ally1)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => (q.Ally1 == ally1 || (ally1 == null && q.Ally1 == null)));
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> ByAlly2(this IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> queryable, int? ally2)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => (q.Ally2 == ally2 || (ally2 == null && q.Ally2 == null)));
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> ByAlly3(this IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> queryable, int? ally3)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => (q.Ally3 == ally3 || (ally3 == null && q.Ally3 == null)));
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> ByAlly4(this IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> queryable, int? ally4)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => (q.Ally4 == ally4 || (ally4 == null && q.Ally4 == null)));
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> ByAlly5(this IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> queryable, int? ally5)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => (q.Ally5 == ally5 || (ally5 == null && q.Ally5 == null)));
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> ByAlly6(this IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> queryable, int? ally6)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => (q.Ally6 == ally6 || (ally6 == null && q.Ally6 == null)));
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> ByAlly7(this IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> queryable, int? ally7)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => (q.Ally7 == ally7 || (ally7 == null && q.Ally7 == null)));
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> ByAlly8(this IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> queryable, int? ally8)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => (q.Ally8 == ally8 || (ally8 == null && q.Ally8 == null)));
        }

        public static VsroShard.Shard_Repository.Entities.AlliedClans GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.AlliedClans> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.AlliedClans> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.AlliedClans> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.AlliedClans> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroShard.Shard_Repository.Entities.AlliedClans>(task);
        }

        #endregion

    }
}
