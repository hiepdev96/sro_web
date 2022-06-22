using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class CharCollectionBookExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.CharCollectionBook GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.CharCollectionBook> queryable, int charID, int themeID, int slotIndex)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharCollectionBook> dbSet)
                return dbSet.Find(charID, themeID, slotIndex);

            return queryable.FirstOrDefault(q => q.CharID == charID
                && q.ThemeID == themeID
                    && q.SlotIndex == slotIndex);
            }

            public static ValueTask<VsroShard.Shard_Repository.Entities.CharCollectionBook> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.CharCollectionBook> queryable, int charID, int themeID, int slotIndex)
            {
                if (queryable is null)
                    throw new ArgumentNullException(nameof(queryable));

                if (queryable is DbSet<VsroShard.Shard_Repository.Entities.CharCollectionBook> dbSet)
                    return dbSet.FindAsync(charID, themeID, slotIndex);

                var task = queryable.FirstOrDefaultAsync(q => q.CharID == charID
                    && q.ThemeID == themeID
                        && q.SlotIndex == slotIndex);
                    return new ValueTask<VsroShard.Shard_Repository.Entities.CharCollectionBook>(task);
                }

                #endregion

            }
        }
