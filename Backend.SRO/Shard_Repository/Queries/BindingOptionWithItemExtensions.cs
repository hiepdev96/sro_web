using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class BindingOptionWithItemExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.BindingOptionWithItem GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.BindingOptionWithItem> queryable, long nItemDBID, byte bOptType, byte nSlot)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.BindingOptionWithItem> dbSet)
                return dbSet.Find(nItemDBID, bOptType, nSlot);

            return queryable.FirstOrDefault(q => q.NItemDBID == nItemDBID
                && q.BOptType == bOptType
                    && q.NSlot == nSlot);
            }

            public static ValueTask<VsroShard.Shard_Repository.Entities.BindingOptionWithItem> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.BindingOptionWithItem> queryable, long nItemDBID, byte bOptType, byte nSlot)
            {
                if (queryable is null)
                    throw new ArgumentNullException(nameof(queryable));

                if (queryable is DbSet<VsroShard.Shard_Repository.Entities.BindingOptionWithItem> dbSet)
                    return dbSet.FindAsync(nItemDBID, bOptType, nSlot);

                var task = queryable.FirstOrDefaultAsync(q => q.NItemDBID == nItemDBID
                    && q.BOptType == bOptType
                        && q.NSlot == nSlot);
                    return new ValueTask<VsroShard.Shard_Repository.Entities.BindingOptionWithItem>(task);
                }

                #endregion

            }
        }
