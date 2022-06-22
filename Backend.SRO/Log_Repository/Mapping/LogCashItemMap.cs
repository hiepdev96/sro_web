using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroLog.Log_Repository.Mapping
{
    public partial class LogCashItemMap
        : IEntityTypeConfiguration<VsroLog.Log_Repository.Entities.LogCashItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroLog.Log_Repository.Entities.LogCashItem> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_LogCashItem", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.RefItemID)
                .IsRequired()
                .HasColumnName("RefItemID")
                .HasColumnType("int");

            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.Cnt)
                .IsRequired()
                .HasColumnName("Cnt")
                .HasColumnType("smallint");

            builder.Property(t => t.EventTime)
                .IsRequired()
                .HasColumnName("EventTime")
                .HasColumnType("datetime");

            builder.Property(t => t.Serial64)
                .IsRequired()
                .HasColumnName("Serial64")
                .HasColumnType("bigint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_LogCashItem";
        }

        public struct Columns
        {
            public const string RefItemID = "RefItemID";
            public const string CharID = "CharID";
            public const string Cnt = "Cnt";
            public const string EventTime = "EventTime";
            public const string Serial64 = "Serial64";
        }
        #endregion
    }
}
