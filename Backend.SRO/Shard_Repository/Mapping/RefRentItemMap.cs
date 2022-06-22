using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefRentItemMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefRentItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefRentItem> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefRentItem", "dbo");

            // key
            builder.HasKey(t => new { t.RentCodeName, t.RefItemID });

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("service")
                .HasColumnType("int");

            builder.Property(t => t.RentCodeName)
                .IsRequired()
                .HasColumnName("RentCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.RefItemID)
                .IsRequired()
                .HasColumnName("RefItemID")
                .HasColumnType("int");

            builder.Property(t => t.CanDelete)
                .IsRequired()
                .HasColumnName("CanDelete")
                .HasColumnType("tinyint");

            builder.Property(t => t.CnaRecharge)
                .IsRequired()
                .HasColumnName("CnaRecharge")
                .HasColumnType("tinyint");

            builder.Property(t => t.RentType)
                .HasColumnName("RentType")
                .HasColumnType("int");

            builder.Property(t => t.StartTime)
                .HasColumnName("StartTime")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.EndTime)
                .HasColumnName("EndTime")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.TimeCnt)
                .HasColumnName("TimeCnt")
                .HasColumnType("tinyint");

            builder.Property(t => t.Time1)
                .HasColumnName("Time1")
                .HasColumnType("int");

            builder.Property(t => t.Time2)
                .HasColumnName("Time2")
                .HasColumnType("int");

            builder.Property(t => t.Time3)
                .HasColumnName("Time3")
                .HasColumnType("int");

            builder.Property(t => t.Time4)
                .HasColumnName("Time4")
                .HasColumnType("int");

            builder.Property(t => t.Time5)
                .HasColumnName("Time5")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefRentItem";
        }

        public struct Columns
        {
            public const string Service = "service";
            public const string RentCodeName = "RentCodeName";
            public const string RefItemID = "RefItemID";
            public const string CanDelete = "CanDelete";
            public const string CnaRecharge = "CnaRecharge";
            public const string RentType = "RentType";
            public const string StartTime = "StartTime";
            public const string EndTime = "EndTime";
            public const string TimeCnt = "TimeCnt";
            public const string Time1 = "Time1";
            public const string Time2 = "Time2";
            public const string Time3 = "Time3";
            public const string Time4 = "Time4";
            public const string Time5 = "Time5";
        }
        #endregion
    }
}
