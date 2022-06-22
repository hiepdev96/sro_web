using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSiegeQuestMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSiegeQuest>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSiegeQuest> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSiegeQuest", "dbo");

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
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.QuestName)
                .IsRequired()
                .HasColumnName("QuestName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.QuestType)
                .IsRequired()
                .HasColumnName("QuestType")
                .HasColumnType("tinyint");

            builder.Property(t => t.RewardConditionTargetCount)
                .IsRequired()
                .HasColumnName("RewardConditionTargetCount")
                .HasColumnType("tinyint");

            builder.Property(t => t.IsAccumulation)
                .IsRequired()
                .HasColumnName("IsAccumulation")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSiegeQuest";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string QuestID = "QuestID";
            public const string QuestName = "QuestName";
            public const string QuestType = "QuestType";
            public const string RewardConditionTargetCount = "RewardConditionTargetCount";
            public const string IsAccumulation = "IsAccumulation";
        }
        #endregion
    }
}
