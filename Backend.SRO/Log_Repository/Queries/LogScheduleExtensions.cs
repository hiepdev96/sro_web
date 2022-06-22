using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroLog.Log_Repository.Queries
{
    public static partial class LogScheduleExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroLog.Log_Repository.Entities.LogSchedule> ById(this IQueryable<VsroLog.Log_Repository.Entities.LogSchedule> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.Id == id);
        }

        public static IQueryable<VsroLog.Log_Repository.Entities.LogSchedule> ByOccureTime(this IQueryable<VsroLog.Log_Repository.Entities.LogSchedule> queryable, DateTime occureTime)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.OccureTime == occureTime);
        }

        #endregion

    }
}
