using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class TrijobRanking4WEBExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.TrijobRanking4WEB> ByNickName(this IQueryable<VsroShard.Shard_Repository.Entities.TrijobRanking4WEB> queryable, string nickName)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.NickName == nickName);
        }

        public static VsroShard.Shard_Repository.Entities.TrijobRanking4WEB GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.TrijobRanking4WEB> queryable, byte trijobType, byte rankType, byte rank)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TrijobRanking4WEB> dbSet)
                return dbSet.Find(trijobType, rankType, rank);

            return queryable.FirstOrDefault(q => q.TrijobType == trijobType
                && q.RankType == rankType
                    && q.Rank == rank);
            }

            public static ValueTask<VsroShard.Shard_Repository.Entities.TrijobRanking4WEB> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.TrijobRanking4WEB> queryable, byte trijobType, byte rankType, byte rank)
            {
                if (queryable is null)
                    throw new ArgumentNullException(nameof(queryable));

                if (queryable is DbSet<VsroShard.Shard_Repository.Entities.TrijobRanking4WEB> dbSet)
                    return dbSet.FindAsync(trijobType, rankType, rank);

                var task = queryable.FirstOrDefaultAsync(q => q.TrijobType == trijobType
                    && q.RankType == rankType
                        && q.Rank == rank);
                    return new ValueTask<VsroShard.Shard_Repository.Entities.TrijobRanking4WEB>(task);
                }

                #endregion

            }
        }
