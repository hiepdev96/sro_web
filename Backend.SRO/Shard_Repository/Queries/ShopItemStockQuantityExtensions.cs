using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class ShopItemStockQuantityExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.ShopItemStockQuantity GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.ShopItemStockQuantity> queryable, int country, string refShopGroupCodeName, string refPackageItemCodeName)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.ShopItemStockQuantity> dbSet)
                return dbSet.Find(country, refShopGroupCodeName, refPackageItemCodeName);

            return queryable.FirstOrDefault(q => q.Country == country
                && q.RefShopGroupCodeName == refShopGroupCodeName
                    && q.RefPackageItemCodeName == refPackageItemCodeName);
            }

            public static ValueTask<VsroShard.Shard_Repository.Entities.ShopItemStockQuantity> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.ShopItemStockQuantity> queryable, int country, string refShopGroupCodeName, string refPackageItemCodeName)
            {
                if (queryable is null)
                    throw new ArgumentNullException(nameof(queryable));

                if (queryable is DbSet<VsroShard.Shard_Repository.Entities.ShopItemStockQuantity> dbSet)
                    return dbSet.FindAsync(country, refShopGroupCodeName, refPackageItemCodeName);

                var task = queryable.FirstOrDefaultAsync(q => q.Country == country
                    && q.RefShopGroupCodeName == refShopGroupCodeName
                        && q.RefPackageItemCodeName == refPackageItemCodeName);
                    return new ValueTask<VsroShard.Shard_Repository.Entities.ShopItemStockQuantity>(task);
                }

                #endregion

            }
        }
