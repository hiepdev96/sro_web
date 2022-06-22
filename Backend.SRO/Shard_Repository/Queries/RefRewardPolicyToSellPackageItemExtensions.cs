using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class RefRewardPolicyToSellPackageItemExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.RefRewardPolicyToSellPackageItem> ByCountry(this IQueryable<VsroShard.Shard_Repository.Entities.RefRewardPolicyToSellPackageItem> queryable, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Country == country);
        }

        public static VsroShard.Shard_Repository.Entities.RefRewardPolicyToSellPackageItem GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.RefRewardPolicyToSellPackageItem> queryable, string refPackageItemCodeName, int fourCC, int country)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefRewardPolicyToSellPackageItem> dbSet)
                return dbSet.Find(refPackageItemCodeName, fourCC, country);

            return queryable.FirstOrDefault(q => q.RefPackageItemCodeName == refPackageItemCodeName
                && q.FourCC == fourCC
                    && q.Country == country);
            }

            public static ValueTask<VsroShard.Shard_Repository.Entities.RefRewardPolicyToSellPackageItem> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.RefRewardPolicyToSellPackageItem> queryable, string refPackageItemCodeName, int fourCC, int country)
            {
                if (queryable is null)
                    throw new ArgumentNullException(nameof(queryable));

                if (queryable is DbSet<VsroShard.Shard_Repository.Entities.RefRewardPolicyToSellPackageItem> dbSet)
                    return dbSet.FindAsync(refPackageItemCodeName, fourCC, country);

                var task = queryable.FirstOrDefaultAsync(q => q.RefPackageItemCodeName == refPackageItemCodeName
                    && q.FourCC == fourCC
                        && q.Country == country);
                    return new ValueTask<VsroShard.Shard_Repository.Entities.RefRewardPolicyToSellPackageItem>(task);
                }

                #endregion

            }
        }
