using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VsroLog.Log_Repository.Queries
{
    public static partial class LogServerEventExtensions
    {
        #region Generated Extensions
        public static IQueryable<VsroLog.Log_Repository.Entities.LogServerEvent> ByEventTime(this IQueryable<VsroLog.Log_Repository.Entities.LogServerEvent> queryable, DateTime eventTime)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.EventTime == eventTime);
        }

        public static VsroLog.Log_Repository.Entities.LogServerEvent GetByKey(this IQueryable<VsroLog.Log_Repository.Entities.LogServerEvent> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroLog.Log_Repository.Entities.LogServerEvent> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<VsroLog.Log_Repository.Entities.LogServerEvent> GetByKeyAsync(this IQueryable<VsroLog.Log_Repository.Entities.LogServerEvent> queryable, int id)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<VsroLog.Log_Repository.Entities.LogServerEvent> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<VsroLog.Log_Repository.Entities.LogServerEvent>(task);
        }

        public static IQueryable<VsroLog.Log_Repository.Entities.LogServerEvent> ByServerEventID(this IQueryable<VsroLog.Log_Repository.Entities.LogServerEvent> queryable, int serverEventID)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            return queryable.Where(q => q.ServerEventID == serverEventID);
        }

        #endregion

    }
}
