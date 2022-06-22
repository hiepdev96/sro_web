using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefQuestRewardItemsMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefQuestRewardItems>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefQuestRewardItems> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefQuestRewardItems", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.QuestID)
                .IsRequired()
                .HasColumnName("QuestID")
                .HasColumnType("int");

            builder.Property(t => t.QuestCodeName)
                .IsRequired()
                .HasColumnName("QuestCodeName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.RewardType)
                .IsRequired()
                .HasColumnName("RewardType")
                .HasColumnType("tinyint");

            builder.Property(t => t.ItemCodeName)
                .IsRequired()
                .HasColumnName("ItemCodeName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.OptionalItemCode)
                .IsRequired()
                .HasColumnName("OptionalItemCode")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128)
                .HasDefaultValueSql("('xxx')");

            builder.Property(t => t.OptionalItemCnt)
                .IsRequired()
                .HasColumnName("OptionalItemCnt")
                .HasColumnType("int");

            builder.Property(t => t.AchieveQuantity)
                .IsRequired()
                .HasColumnName("AchieveQuantity")
                .HasColumnType("int");

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
            public const string Name = "_RefQuestRewardItems";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string QuestID = "QuestID";
            public const string QuestCodeName = "QuestCodeName";
            public const string RewardType = "RewardType";
            public const string ItemCodeName = "ItemCodeName";
            public const string OptionalItemCode = "OptionalItemCode";
            public const string OptionalItemCnt = "OptionalItemCnt";
            public const string AchieveQuantity = "AchieveQuantity";
            public const string RentItemCodeName = "RentItemCodeName";
            public const string Param1 = "Param1";
            public const string Param1Desc = "Param1_Desc";
            public const string Param2 = "Param2";
            public const string Param2Desc = "Param2_Desc";
        }
        #endregion
    }
}
