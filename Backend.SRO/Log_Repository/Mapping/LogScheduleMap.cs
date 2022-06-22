using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroLog.Log_Repository.Mapping
{
    public partial class LogScheduleMap
        : IEntityTypeConfiguration<VsroLog.Log_Repository.Entities.LogSchedule>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroLog.Log_Repository.Entities.LogSchedule> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_LogSchedule", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.ServerType)
                .IsRequired()
                .HasColumnName("ServerType")
                .HasColumnType("varchar(124)")
                .HasMaxLength(124);

            builder.Property(t => t.ServerBodyID)
                .IsRequired()
                .HasColumnName("ServerBodyID")
                .HasColumnType("int");

            builder.Property(t => t.ScheduleDefine)
                .IsRequired()
                .HasColumnName("ScheduleDefine")
                .HasColumnType("varchar(124)")
                .HasMaxLength(124);

            builder.Property(t => t.ScheduleIdx)
                .IsRequired()
                .HasColumnName("ScheduleIdx")
                .HasColumnType("int");

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.OccureTime)
                .IsRequired()
                .HasColumnName("OccureTime")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_LogSchedule";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string ServerType = "ServerType";
            public const string ServerBodyID = "ServerBodyID";
            public const string ScheduleDefine = "ScheduleDefine";
            public const string ScheduleIdx = "ScheduleIdx";
            public const string Type = "Type";
            public const string OccureTime = "OccureTime";
        }
        #endregion
    }
}
