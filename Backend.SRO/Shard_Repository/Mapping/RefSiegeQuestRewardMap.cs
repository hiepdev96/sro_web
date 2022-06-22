using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSiegeQuestRewardMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSiegeQuestReward>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSiegeQuestReward> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSiegeQuestReward", "dbo");

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

            builder.Property(t => t.RewardType)
                .IsRequired()
                .HasColumnName("RewardType")
                .HasColumnType("tinyint");

            builder.Property(t => t.RewardRefID)
                .IsRequired()
                .HasColumnName("RewardRefID")
                .HasColumnType("int");

            builder.Property(t => t.RewardValue)
                .IsRequired()
                .HasColumnName("RewardValue")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSiegeQuestReward";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string QuestID = "QuestID";
            public const string RewardType = "RewardType";
            public const string RewardRefID = "RewardRefID";
            public const string RewardValue = "RewardValue";
        }
        #endregion
    }
}
