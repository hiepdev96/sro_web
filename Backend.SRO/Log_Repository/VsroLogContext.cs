using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VsroLog.Log_Repository
{
    public partial class VsroLogContext : DbContext
    {
        public VsroLogContext(DbContextOptions<VsroLogContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<VsroLog.Log_Repository.Entities.LogCashItem> LogCashItems { get; set; }

        public virtual DbSet<VsroLog.Log_Repository.Entities.LogEventChar> LogEventChars { get; set; }

        public virtual DbSet<VsroLog.Log_Repository.Entities.LogEventItem> LogEventItems { get; set; }

        public virtual DbSet<VsroLog.Log_Repository.Entities.LogEventSiegeFortress> LogEventSiegeFortresses { get; set; }

        public virtual DbSet<VsroLog.Log_Repository.Entities.LogSchedule> LogSchedules { get; set; }

        public virtual DbSet<VsroLog.Log_Repository.Entities.LogServerEvent> LogServerEvents { get; set; }

        public virtual DbSet<VsroLog.Log_Repository.Entities.StatisticsGoldIncrementData> StatisticsGoldIncrementData { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new VsroLog.Log_Repository.Mapping.LogCashItemMap());
            modelBuilder.ApplyConfiguration(new VsroLog.Log_Repository.Mapping.LogEventCharMap());
            modelBuilder.ApplyConfiguration(new VsroLog.Log_Repository.Mapping.LogEventItemMap());
            modelBuilder.ApplyConfiguration(new VsroLog.Log_Repository.Mapping.LogEventSiegeFortressMap());
            modelBuilder.ApplyConfiguration(new VsroLog.Log_Repository.Mapping.LogScheduleMap());
            modelBuilder.ApplyConfiguration(new VsroLog.Log_Repository.Mapping.LogServerEventMap());
            modelBuilder.ApplyConfiguration(new VsroLog.Log_Repository.Mapping.StatisticsGoldIncrementDataMap());
            #endregion
        }
    }
}
