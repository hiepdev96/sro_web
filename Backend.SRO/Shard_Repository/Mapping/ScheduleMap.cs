using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class ScheduleMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.Schedule>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.Schedule> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_Schedule", "dbo");

            // key
            builder.HasKey(t => t.ScheduleIdx);

            // properties
            builder.Property(t => t.ScheduleIdx)
                .IsRequired()
                .HasColumnName("ScheduleIdx")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ScheduleDefineIdx)
                .IsRequired()
                .HasColumnName("ScheduleDefineIdx")
                .HasColumnType("int");

            builder.Property(t => t.DateStart)
                .IsRequired()
                .HasColumnName("DateStart")
                .HasColumnType("datetime");

            builder.Property(t => t.DateEnd)
                .IsRequired()
                .HasColumnName("DateEnd")
                .HasColumnType("datetime");

            builder.Property(t => t.MainIntervalType)
                .IsRequired()
                .HasColumnName("MainInterval_Type")
                .HasColumnType("int");

            builder.Property(t => t.MainIntervalTypeDate)
                .IsRequired()
                .HasColumnName("MainInterval_TypeDate")
                .HasColumnType("int");

            builder.Property(t => t.SubIntervalDayOfWeek)
                .HasColumnName("SubInterval_DayOfWeek")
                .HasColumnType("tinyint");

            builder.Property(t => t.SubIntervalDays)
                .HasColumnName("SubInterval_Days")
                .HasColumnType("tinyint");

            builder.Property(t => t.SubIntervalWeeks)
                .HasColumnName("SubInterval_Weeks")
                .HasColumnType("tinyint");

            builder.Property(t => t.SubIntervalMonths)
                .HasColumnName("SubInterval_Months")
                .HasColumnType("tinyint");

            builder.Property(t => t.SubIntervalStartTimeHour)
                .HasColumnName("SubInterval_StartTimeHour")
                .HasColumnType("tinyint");

            builder.Property(t => t.SubIntervalStartTimeMinute)
                .HasColumnName("SubInterval_StartTimeMinute")
                .HasColumnType("tinyint");

            builder.Property(t => t.SubIntervalStartTimeSecond)
                .HasColumnName("SubInterval_StartTimeSecond")
                .HasColumnType("tinyint");

            builder.Property(t => t.SubIntervalDurationSecond)
                .HasColumnName("SubInterval_DurationSecond")
                .HasColumnType("int");

            builder.Property(t => t.SubIntervalRepititionTerm)
                .HasColumnName("SubInterval_RepititionTerm")
                .HasColumnType("int");

            builder.Property(t => t.SubIntervalMaintainTime)
                .HasColumnName("SubInterval_MaintainTime")
                .HasColumnType("int");

            builder.Property(t => t.Param)
                .HasColumnName("Param")
                .HasColumnType("varchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar(2000)")
                .HasMaxLength(2000);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_Schedule";
        }

        public struct Columns
        {
            public const string ScheduleIdx = "ScheduleIdx";
            public const string ScheduleDefineIdx = "ScheduleDefineIdx";
            public const string DateStart = "DateStart";
            public const string DateEnd = "DateEnd";
            public const string MainIntervalType = "MainInterval_Type";
            public const string MainIntervalTypeDate = "MainInterval_TypeDate";
            public const string SubIntervalDayOfWeek = "SubInterval_DayOfWeek";
            public const string SubIntervalDays = "SubInterval_Days";
            public const string SubIntervalWeeks = "SubInterval_Weeks";
            public const string SubIntervalMonths = "SubInterval_Months";
            public const string SubIntervalStartTimeHour = "SubInterval_StartTimeHour";
            public const string SubIntervalStartTimeMinute = "SubInterval_StartTimeMinute";
            public const string SubIntervalStartTimeSecond = "SubInterval_StartTimeSecond";
            public const string SubIntervalDurationSecond = "SubInterval_DurationSecond";
            public const string SubIntervalRepititionTerm = "SubInterval_RepititionTerm";
            public const string SubIntervalMaintainTime = "SubInterval_MaintainTime";
            public const string Param = "Param";
            public const string Description = "Description";
        }
        #endregion
    }
}
