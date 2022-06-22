using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefShopGroupExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefShopGroup> ByCountry(this IQueryable<VsroShard.Shard_Repository.Entities.RefShopGroup> queryable, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Country == country);
        }

        public static VsroShard.Shard_Repository.Entities.RefShopGroup GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefShopGroup> queryable, int country, short id, string refNPCCodeName)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefShopGroup> dbSet)
                return dbSet.Find(country, id, refNPCCodeName);

            return queryable.FirstOrDefault(q => q.Country == country
                && q.Id == id
                    && q.RefNPCCodeName == refNPCCodeName);
            }

            public static ValueTask<VsroShard.Shard_Repository.Entities.RefShopGroup> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefShopGroup> queryable, int country, short id, string refNPCCodeName)
            {
                if (queryable is null)
                    throw new ArgumentNullException(nameof(queryable));

                if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefShopGroup> dbSet)
                    return dbSet.FindAsync(country, id, refNPCCodeName);

                var task = queryable.FirstOrDefaultAsync(q => q.Country == country
                    && q.Id == id
                        && q.RefNPCCodeName == refNPCCodeName);
                    return new ValueTask<VsroShard.Shard_Repository.Entities.RefShopGroup>(task);
                }

                #endregion

            }
        }
