using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefMappingShopWithTabExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefMappingShopWithTab> ByCountry(this IQueryable<VsroShard.Shard_Repository.Entities.RefMappingShopWithTab> queryable, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Country == country);
        }

        public static VsroShard.Shard_Repository.Entities.RefMappingShopWithTab GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefMappingShopWithTab> queryable, int country, string refShopCodeName, string refTabGroupCodeName)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefMappingShopWithTab> dbSet)
                return dbSet.Find(country, refShopCodeName, refTabGroupCodeName);

            return queryable.FirstOrDefault(q => q.Country == country
                && q.RefShopCodeName == refShopCodeName
                    && q.RefTabGroupCodeName == refTabGroupCodeName);
            }

            public static ValueTask<VsroShard.Shard_Repository.Entities.RefMappingShopWithTab> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefMappingShopWithTab> queryable, int country, string refShopCodeName, string refTabGroupCodeName)
            {
                if (queryable is null)
                    throw new ArgumentNullException(nameof(queryable));

                if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefMappingShopWithTab> dbSet)
                    return dbSet.FindAsync(country, refShopCodeName, refTabGroupCodeName);

                var task = queryable.FirstOrDefaultAsync(q => q.Country == country
                    && q.RefShopCodeName == refShopCodeName
                        && q.RefTabGroupCodeName == refTabGroupCodeName);
                    return new ValueTask<VsroShard.Shard_Repository.Entities.RefMappingShopWithTab>(task);
                }

                #endregion

            }
        }
