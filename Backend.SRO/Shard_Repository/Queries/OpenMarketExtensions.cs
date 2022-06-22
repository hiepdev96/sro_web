using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class OpenMarketExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.OpenMarket> ByItemID(this IQueryable<VsroShard.Shard_Repository.Entities.OpenMarket> queryable, long itemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.ItemID == itemID);
        }

        public static VsroShard.Shard_Repository.Entities.OpenMarket GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.OpenMarket> queryable, int jid)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.OpenMarket> dbSet)
                return dbSet.Find(jid);

            return queryable.FirstOrDefault(q => q.Jid == jid);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.OpenMarket> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.OpenMarket> queryable, int jid)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.OpenMarket> dbSet)
                return dbSet.FindAsync(jid);

            var task = queryable.FirstOrDefaultAsync(q => q.Jid == jid);
            return new ValueTask<VsroShard.Shard_Repository.Entities.OpenMarket>(task);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.OpenMarket> ByJidStatus(this IQueryable<VsroShard.Shard_Repository.Entities.OpenMarket> queryable, int jid, byte status)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Jid == jid
                && q.Status == status);
        }

        public static IQueryable<VsroShard.Shard_Repository.Entities.OpenMarket> ByStatusTidGroupIDItemClassRegDate(this IQueryable<VsroShard.Shard_Repository.Entities.OpenMarket> queryable, byte status, int tidGroupID, int itemClass, DateTime regDate)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Status == status
                && q.TidGroupID == tidGroupID
                    && q.ItemClass == itemClass
                        && q.RegDate == regDate);
                }

                public static IQueryable<VsroShard.Shard_Repository.Entities.OpenMarket> ByTidGroupIDStatusEndDate(this IQueryable<VsroShard.Shard_Repository.Entities.OpenMarket> queryable, int tidGroupID, byte status, DateTime endDate)
                {
                    if (queryable is null)
                        throw new ArgumentNullException(nameof(queryable));

                    return queryable.Where(q => q.TidGroupID == tidGroupID
                        && q.Status == status
                            && q.EndDate == endDate);
                    }

                    #endregion

                }
            }
