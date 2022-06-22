using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class ResultOfPackageItemToMappingWithServerSideExtensions
    {
        #region Generated Extensions
        public static VsroShard.Shard_Repository.Entities.ResultOfPackageItemToMappingWithServerSide GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.ResultOfPackageItemToMappingWithServerSide> queryable, int charID, int slot, long refItemSerial64, long refItemDBID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.ResultOfPackageItemToMappingWithServerSide> dbSet)
                return dbSet.Find(charID, slot, refItemSerial64, refItemDBID);

            return queryable.FirstOrDefault(q => q.CharID == charID
                && q.Slot == slot
                    && q.RefItemSerial64 == refItemSerial64
                        && q.RefItemDBID == refItemDBID);
                }

                public static ValueTask<VsroShard.Shard_Repository.Entities.ResultOfPackageItemToMappingWithServerSide> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.ResultOfPackageItemToMappingWithServerSide> queryable, int charID, int slot, long refItemSerial64, long refItemDBID)
                {
                    if (queryable is null)
                        throw new ArgumentNullException(nameof(queryable));

                    if (queryable is DbSet<VsroShard.Shard_Repository.Entities.ResultOfPackageItemToMappingWithServerSide> dbSet)
                        return dbSet.FindAsync(charID, slot, refItemSerial64, refItemDBID);

                    var task = queryable.FirstOrDefaultAsync(q => q.CharID == charID
                        && q.Slot == slot
                            && q.RefItemSerial64 == refItemSerial64
                                && q.RefItemDBID == refItemDBID);
                            return new ValueTask<VsroShard.Shard_Repository.Entities.ResultOfPackageItemToMappingWithServerSide>(task);
                        }

                        #endregion

                    }
                }
