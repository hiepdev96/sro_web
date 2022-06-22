using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefEventRewardItemsMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefEventRewardItems>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefEventRewardItems> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefEventRewardItems", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.EventID)
                .IsRequired()
                .HasColumnName("EventID")
                .HasColumnType("int");

            builder.Property(t => t.EventCodeName)
                .IsRequired()
                .HasColumnName("EventCodeName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.ItemCodeName)
                .IsRequired()
                .HasColumnName("ItemCodeName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.PayCount)
                .IsRequired()
                .HasColumnName("PayCount")
                .HasColumnType("int");

            builder.Property(t => t.AchieveRatio)
                .IsRequired()
                .HasColumnName("AchieveRatio")
                .HasColumnType("real");

            builder.Property(t => t.RentItemCodeName)
                .IsRequired()
                .HasColumnName("RentItemCodeName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128)
                .HasDefaultValueSql("('xxx')");

            builder.Property(t => t.Param1)
                .IsRequired()
                .HasColumnName("Param1")
                .HasColumnType("int");

            builder.Property(t => t.Param1Desc)
                .IsRequired()
                .HasColumnName("Param1_Desc")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128)
                .HasDefaultValueSql("('xxx')");

            builder.Property(t => t.Param2)
                .IsRequired()
                .HasColumnName("Param2")
                .HasColumnType("int");

            builder.Property(t => t.Param2Desc)
                .IsRequired()
                .HasColumnName("Param2_Desc")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128)
                .HasDefaultValueSql("('xxx')");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefEventRewardItems";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string EventID = "EventID";
            public const string EventCodeName = "EventCodeName";
            public const string ItemCodeName = "ItemCodeName";
            public const string PayCount = "PayCount";
            public const string AchieveRatio = "AchieveRatio";
            public const string RentItemCodeName = "RentItemCodeName";
            public const string Param1 = "Param1";
            public const string Param1Desc = "Param1_Desc";
            public const string Param2 = "Param2";
            public const string Param2Desc = "Param2_Desc";
        }
        #endregion
    }
}
