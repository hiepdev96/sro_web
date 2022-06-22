using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroLog.Log_Repository.Queries
{
    public static partial class LogEventCharExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroLog.Log_Repository.Entities.LogEventChar> ByCharID(this IQueryable<VsroLog.Log_Repository.Entities.LogEventChar> queryable, int charID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.CharID == charID);
        }

        #endregion

    }
}
