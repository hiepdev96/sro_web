using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefShopGoodsExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefShopGoods> ByCountry(this IQueryable<VsroShard.Shard_Repository.Entities.RefShopGoods> queryable, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Country == country);
        }

        public static VsroShard.Shard_Repository.Entities.RefShopGoods GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefShopGoods> queryable, int country, string refTabCodeName, string refPackageItemCodeName)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefShopGoods> dbSet)
                return dbSet.Find(country, refTabCodeName, refPackageItemCodeName);

            return queryable.FirstOrDefault(q => q.Country == country
                && q.RefTabCodeName == refTabCodeName
                    && q.RefPackageItemCodeName == refPackageItemCodeName);
            }

            public static ValueTask<VsroShard.Shard_Repository.Entities.RefShopGoods> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefShopGoods> queryable, int country, string refTabCodeName, string refPackageItemCodeName)
            {
                if (queryable is null)
                    throw new ArgumentNullException(nameof(queryable));

                if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefShopGoods> dbSet)
                    return dbSet.FindAsync(country, refTabCodeName, refPackageItemCodeName);

                var task = queryable.FirstOrDefaultAsync(q => q.Country == country
                    && q.RefTabCodeName == refTabCodeName
                        && q.RefPackageItemCodeName == refPackageItemCodeName);
                    return new ValueTask<VsroShard.Shard_Repository.Entities.RefShopGoods>(task);
                }

                #endregion

            }
        }
