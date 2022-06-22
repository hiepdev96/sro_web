using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Queries
{
    public static partial class AssociationReputationExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroShard.Shard_Repository.Entities.AssociationReputation> ByAssociationCodeName(this IQueryable<VsroShard.Shard_Repository.Entities.AssociationReputation> queryable, string associationCodeName)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.AssociationCodeName == associationCodeName);
        }

        public static VsroShard.Shard_Repository.Entities.AssociationReputation GetByKey(this IQueryable<VsroShard.Shard_Repository.Entities.AssociationReputation> queryable, string associationCodeName, string associationTypeName)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.AssociationReputation> dbSet)
                return dbSet.Find(associationCodeName, associationTypeName);

            return queryable.FirstOrDefault(q => q.AssociationCodeName == associationCodeName
                && q.AssociationTypeName == associationTypeName);
        }

        public static ValueTask<VsroShard.Shard_Repository.Entities.AssociationReputation> GetByKeyAsync(this IQueryable<VsroShard.Shard_Repository.Entities.AssociationReputation> queryable, string associationCodeName, string associationTypeName)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroShard.Shard_Repository.Entities.AssociationReputation> dbSet)
                return dbSet.FindAsync(associationCodeName, associationTypeName);

            var task = queryable.FirstOrDefaultAsync(q => q.AssociationCodeName == associationCodeName
                && q.AssociationTypeName == associationTypeName);
            return new ValueTask<VsroShard.Shard_Repository.Entities.AssociationReputation>(task);
        }

        #endregion

    }
}
