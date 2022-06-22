using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefMappingShopGroupExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefMappingShopGroup> ByCountry(this IQueryable<VsroShard.Shard_Repository.Entities.RefMappingShopGroup> queryable, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Country == country);
        }

        public static VsroShard.Shard_Repository.Entities.RefMappingShopGroup GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefMappingShopGroup> queryable, int country, string refShopGroupCodeName, string refShopCodeName)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefMappingShopGroup> dbSet)
                return dbSet.Find(country, refShopGroupCodeName, refShopCodeName);

            return queryable.FirstOrDefault(q => q.Country == country
                && q.RefShopGroupCodeName == refShopGroupCodeName
                    && q.RefShopCodeName == refShopCodeName);
            }

            public static ValueTask<VsroShard.Shard_Repository.Entities.RefMappingShopGroup> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefMappingShopGroup> queryable, int country, string refShopGroupCodeName, string refShopCodeName)
            {
                if (queryable is null)
                    throw new ArgumentNullException(nameof(queryable));

                if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefMappingShopGroup> dbSet)
                    return dbSet.FindAsync(country, refShopGroupCodeName, refShopCodeName);

                var task = queryable.FirstOrDefaultAsync(q => q.Country == country
                    && q.RefShopGroupCodeName == refShopGroupCodeName
                        && q.RefShopCodeName == refShopCodeName);
                    return new ValueTask<VsroShard.Shard_Repository.Entities.RefMappingShopGroup>(task);
                }

                #endregion

            }
        }
