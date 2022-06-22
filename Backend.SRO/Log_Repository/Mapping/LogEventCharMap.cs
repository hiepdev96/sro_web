using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroLog.Log_Repository.Mapping
{
    public partial class LogEventCharMap
        : IEntityTypeConfiguration<VsroLog.Log_Repository.Entities.LogEventChar>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroLog.Log_Repository.Entities.LogEventChar> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_LogEventChar", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.EventTime)
                .IsRequired()
                .HasColumnName("EventTime")
                .HasColumnType("datetime");

            builder.Property(t => t.EventID)
                .IsRequired()
                .HasColumnName("EventID")
                .HasColumnType("tinyint");

            builder.Property(t => t.Data1)
                .IsRequired()
                .HasColumnName("Data1")
                .HasColumnType("int");

            builder.Property(t => t.Data2)
                .IsRequired()
                .HasColumnName("Data2")
                .HasColumnType("int");

            builder.Property(t => t.EventPos)
                .HasColumnName("EventPos")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.StrDesc)
                .HasColumnName("strDesc")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_LogEventChar";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string EventTime = "EventTime";
            public const string EventID = "EventID";
            public const string Data1 = "Data1";
            public const string Data2 = "Data2";
            public const string EventPos = "EventPos";
            public const string StrDesc = "strDesc";
        }
        #endregion
    }
}
