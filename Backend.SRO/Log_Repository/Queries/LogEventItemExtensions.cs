using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroLog.Log_Repository.Queries
{
    public static partial class LogEventItemExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroLog.Log_Repository.Entities.LogEventItem> ByCharID(this IQueryable<VsroLog.Log_Repository.Entities.LogEventItem> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.CharID == charID);
        }

        public static IQueryable<VsroLog.Log_Repository.Entities.LogEventItem> BySerial64(this IQueryable<VsroLog.Log_Repository.Entities.LogEventItem> queryable, long serial64)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Serial64 == serial64);
        }

        #endregion

    }
}
