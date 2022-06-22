using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefQuestRewardMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefQuestReward>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefQuestReward> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefQuestReward", "dbo");

            // key
            builder.HasKey(t => t.QuestID);

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

            builder.Property(t => t.IsView)
                .IsRequired()
                .HasColumnName("IsView")
                .HasColumnType("tinyint");

            builder.Property(t => t.IsBasicReward)
                .IsRequired()
                .HasColumnName("IsBasicReward")
                .HasColumnType("tinyint");

            builder.Property(t => t.IsItemReward)
                .IsRequired()
                .HasColumnName("IsItemReward")
                .HasColumnType("tinyint");

            builder.Property(t => t.IsCheckCondition)
                .IsRequired()
                .HasColumnName("IsCheckCondition")
                .HasColumnType("tinyint");

            builder.Property(t => t.IsCheckCountry)
                .IsRequired()
                .HasColumnName("IsCheckCountry")
                .HasColumnType("tinyint");

            builder.Property(t => t.IsCheckClass)
                .IsRequired()
                .HasColumnName("IsCheckClass")
                .HasColumnType("tinyint");

            builder.Property(t => t.IsCheckGender)
                .IsRequired()
                .HasColumnName("IsCheckGender")
                .HasColumnType("tinyint");

            builder.Property(t => t.Gold)
                .IsRequired()
                .HasColumnName("Gold")
                .HasColumnType("int");

            builder.Property(t => t.Exp)
                .IsRequired()
                .HasColumnName("Exp")
                .HasColumnType("int");

            builder.Property(t => t.SPExp)
                .IsRequired()
                .HasColumnName("SPExp")
                .HasColumnType("int");

            builder.Property(t => t.Sp)
                .IsRequired()
                .HasColumnName("SP")
                .HasColumnType("int");

            builder.Property(t => t.Ap)
                .IsRequired()
                .HasColumnName("AP")
                .HasColumnType("int");

            builder.Property(t => t.APType)
                .IsRequired()
                .HasColumnName("APType")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128)
                .HasDefaultValueSql("('xxx')");

            builder.Property(t => t.Hwan)
                .IsRequired()
                .HasColumnName("Hwan")
                .HasColumnType("tinyint");

            builder.Property(t => t.Inventory)
                .IsRequired()
                .HasColumnName("Inventory")
                .HasColumnType("tinyint");

            builder.Property(t => t.ItemRewardType)
                .IsRequired()
                .HasColumnName("ItemRewardType")
                .HasColumnType("tinyint");

            builder.Property(t => t.SelectionCnt)
                .IsRequired()
                .HasColumnName("SelectionCnt")
                .HasColumnType("tinyint");

            builder.Property(t => t.Param1)
                .IsRequired()
                .HasColumnName("Param1")
                .HasColumnType("bigint");

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

            builder.Property(t => t.Param3)
                .IsRequired()
                .HasColumnName("Param3")
                .HasColumnType("int");

            builder.Property(t => t.Param3Desc)
                .IsRequired()
                .HasColumnName("Param3_Desc")
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
            public const string Name = "_RefQuestReward";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string QuestID = "QuestID";
            public const string QuestCodeName = "QuestCodeName";
            public const string IsView = "IsView";
            public const string IsBasicReward = "IsBasicReward";
            public const string IsItemReward = "IsItemReward";
            public const string IsCheckCondition = "IsCheckCondition";
            public const string IsCheckCountry = "IsCheckCountry";
            public const string IsCheckClass = "IsCheckClass";
            public const string IsCheckGender = "IsCheckGender";
            public const string Gold = "Gold";
            public const string Exp = "Exp";
            public const string SPExp = "SPExp";
            public const string Sp = "SP";
            public const string Ap = "AP";
            public const string APType = "APType";
            public const string Hwan = "Hwan";
            public const string Inventory = "Inventory";
            public const string ItemRewardType = "ItemRewardType";
            public const string SelectionCnt = "SelectionCnt";
            public const string Param1 = "Param1";
            public const string Param1Desc = "Param1_Desc";
            public const string Param2 = "Param2";
            public const string Param2Desc = "Param2_Desc";
            public const string Param3 = "Param3";
            public const string Param3Desc = "Param3_Desc";
        }
        #endregion
    }
}
