using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class TrainingCampBuffStatusExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.TrainingCampBuffStatus GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.TrainingCampBuffStatus> queryable, int campID, int recipientCharID, byte buffSlotIdx)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TrainingCampBuffStatus> dbSet)
                return dbSet.Find(campID, recipientCharID, buffSlotIdx);

            return queryable.FirstOrDefault(q => q.CampID == campID
                && q.RecipientCharID == recipientCharID
                    && q.BuffSlotIdx == buffSlotIdx);
            }

            public static ValueTask<VsroShard.Shard_Repository.Entities.TrainingCampBuffStatus> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.TrainingCampBuffStatus> queryable, int campID, int recipientCharID, byte buffSlotIdx)
            {
                if (queryable is null)
                    throw new ArgumentNullException(nameof(queryable));

                if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TrainingCampBuffStatus> dbSet)
                    return dbSet.FindAsync(campID, recipientCharID, buffSlotIdx);

                var task = queryable.FirstOrDefaultAsync(q => q.CampID == campID
                    && q.RecipientCharID == recipientCharID
                        && q.BuffSlotIdx == buffSlotIdx);
                    return new ValueTask<VsroShard.Shard_Repository.Entities.TrainingCampBuffStatus>(task);
                }

                #endregion

            }
        }
