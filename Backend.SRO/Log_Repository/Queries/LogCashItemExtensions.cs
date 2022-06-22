using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroLog.Log_Repository.Queries
{
    public static partial class LogCashItemExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroLog.Log_Repository.Entities.LogCashItem> ByRefItemID(this IQueryable<VsroLog.Log_Repository.Entities.LogCashItem> queryable, int refItemID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.RefItemID == refItemID);
        }

        public static IQueryable<VsroLog.Log_Repository.Entities.LogCashItem> BySerial64(this IQueryable<VsroLog.Log_Repository.Entities.LogCashItem> queryable, long serial64)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Serial64 == serial64);
        }

        #endregion

    }
}
