using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RentItemInfoMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RentItemInfo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RentItemInfo> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RentItemInfo", "dbo");

            // key
            builder.HasKey(t => t.NItemDBID);

            // properties
            builder.Property(t => t.NItemDBID)
                .IsRequired()
                .HasColumnName("nItemDBID")
                .HasColumnType("bigint");

            builder.Property(t => t.NRentType)
                .IsRequired()
                .HasColumnName("nRentType")
                .HasColumnType("int");

            builder.Property(t => t.NCanDelete)
                .IsRequired()
                .HasColumnName("nCanDelete")
                .HasColumnType("smallint");

            builder.Property(t => t.NCanRecharge)
                .IsRequired()
                .HasColumnName("nCanRecharge")
                .HasColumnType("smallint");

            builder.Property(t => t.PeriodBeginTime)
                .IsRequired()
                .HasColumnName("PeriodBeginTime")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.PeriodEndTime)
                .IsRequired()
                .HasColumnName("PeriodEndTime")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.MeterRateTime)
                .HasColumnName("MeterRateTime")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.NPackingState)
                .HasColumnName("nPackingState")
                .HasColumnType("smallint");

            builder.Property(t => t.NPackingTime)
                .HasColumnName("nPackingTime")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RentItemInfo";
        }

        public struct Columns
        {
            public const string NItemDBID = "nItemDBID";
            public const string NRentType = "nRentType";
            public const string NCanDelete = "nCanDelete";
            public const string NCanRecharge = "nCanRecharge";
            public const string PeriodBeginTime = "PeriodBeginTime";
            public const string PeriodEndTime = "PeriodEndTime";
            public const string MeterRateTime = "MeterRateTime";
            public const string NPackingState = "nPackingState";
            public const string NPackingTime = "nPackingTime";
        }
        #endregion
    }
}
