using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefPricePolicyOfItemExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefPricePolicyOfItem> ByCountry(this IQueryable<VsroShard.Shard_Repository.Entities.RefPricePolicyOfItem> queryable, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Country == country);
        }

        public static VsroShard.Shard_Repository.Entities.RefPricePolicyOfItem GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefPricePolicyOfItem> queryable, string refPackageItemCodeName, int paymentDevice, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefPricePolicyOfItem> dbSet)
                return dbSet.Find(refPackageItemCodeName, paymentDevice, country);

            return queryable.FirstOrDefault(q => q.RefPackageItemCodeName == refPackageItemCodeName
                && q.PaymentDevice == paymentDevice
                    && q.Country == country);
            }

            public static ValueTask<VsroShard.Shard_Repository.Entities.RefPricePolicyOfItem> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefPricePolicyOfItem> queryable, string refPackageItemCodeName, int paymentDevice, int country)
            {
                if (queryable is null)
                    throw new ArgumentNullException(nameof(queryable));

                if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefPricePolicyOfItem> dbSet)
                    return dbSet.FindAsync(refPackageItemCodeName, paymentDevice, country);

                var task = queryable.FirstOrDefaultAsync(q => q.RefPackageItemCodeName == refPackageItemCodeName
                    && q.PaymentDevice == paymentDevice
                        && q.Country == country);
                    return new ValueTask<VsroShard.Shard_Repository.Entities.RefPricePolicyOfItem>(task);
                }

                #endregion

            }
        }
