using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroLog.Log_Repository.Mapping
{
    public partial class LogEventItemMap
        : IEntityTypeConfiguration<VsroLog.Log_Repository.Entities.LogEventItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroLog.Log_Repository.Entities.LogEventItem> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_LogEventItem", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.EventTime)
                .IsRequired()
                .HasColumnName("EventTime")
                .HasColumnType("datetime");

            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.ItemRefID)
                .IsRequired()
                .HasColumnName("ItemRefID")
                .HasColumnType("int");

            builder.Property(t => t.DwData)
                .IsRequired()
                .HasColumnName("dwData")
                .HasColumnType("int");

            builder.Property(t => t.TargetStorage)
                .IsRequired()
                .HasColumnName("TargetStorage")
                .HasColumnType("tinyint");

            builder.Property(t => t.Operation)
                .IsRequired()
                .HasColumnName("Operation")
                .HasColumnType("tinyint");

            builder.Property(t => t.SlotFrom)
                .IsRequired()
                .HasColumnName("Slot_From")
                .HasColumnType("tinyint");

            builder.Property(t => t.SlotTo)
                .IsRequired()
                .HasColumnName("Slot_To")
                .HasColumnType("tinyint");

            builder.Property(t => t.EventPos)
                .HasColumnName("EventPos")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.StrDesc)
                .HasColumnName("strDesc")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Serial64)
                .IsRequired()
                .HasColumnName("Serial64")
                .HasColumnType("bigint");

            builder.Property(t => t.Gold)
                .HasColumnName("Gold")
                .HasColumnType("bigint")
                .HasDefaultValueSql("(0)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_LogEventItem";
        }

        public struct Columns
        {
            public const string EventTime = "EventTime";
            public const string CharID = "CharID";
            public const string ItemRefID = "ItemRefID";
            public const string DwData = "dwData";
            public const string TargetStorage = "TargetStorage";
            public const string Operation = "Operation";
            public const string SlotFrom = "Slot_From";
            public const string SlotTo = "Slot_To";
            public const string EventPos = "EventPos";
            public const string StrDesc = "strDesc";
            public const string Serial64 = "Serial64";
            public const string Gold = "Gold";
        }
        #endregion
    }
}
