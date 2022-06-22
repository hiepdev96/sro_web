using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class CharQuestMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.CharQuest>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.CharQuest> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_CharQuest", "dbo");

            // key
            builder.HasKey(t => new { t.CharID, t.QuestID });

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.QuestID)
                .IsRequired()
                .HasColumnName("QuestID")
                .HasColumnType("int");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("tinyint");

            builder.Property(t => t.AchievementCount)
                .IsRequired()
                .HasColumnName("AchievementCount")
                .HasColumnType("smallint");

            builder.Property(t => t.StartTime)
                .IsRequired()
                .HasColumnName("StartTime")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.EndTime)
                .IsRequired()
                .HasColumnName("EndTime")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.QuestData1)
                .IsRequired()
                .HasColumnName("QuestData1")
                .HasColumnType("bigint");

            builder.Property(t => t.QuestData2)
                .IsRequired()
                .HasColumnName("QuestData2")
                .HasColumnType("bigint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_CharQuest";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string QuestID = "QuestID";
            public const string Status = "Status";
            public const string AchievementCount = "AchievementCount";
            public const string StartTime = "StartTime";
            public const string EndTime = "EndTime";
            public const string QuestData1 = "QuestData1";
            public const string QuestData2 = "QuestData2";
        }
        #endregion
    }
}
