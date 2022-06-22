using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefServerEventMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefServerEvent>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefServerEvent> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefServerEvent", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int");

            builder.Property(t => t.DetectingTargetType)
                .IsRequired()
                .HasColumnName("DetectingTargetType")
                .HasColumnType("tinyint");

            builder.Property(t => t.DetectingTargetID)
                .IsRequired()
                .HasColumnName("DetectingTargetID")
                .HasColumnType("int");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.BeginDate)
                .IsRequired()
                .HasColumnName("BeginDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EndDate)
                .IsRequired()
                .HasColumnName("EndDate")
                .HasColumnType("datetime");

            builder.Property(t => t.NotificationTypeDetectingTarget)
                .IsRequired()
                .HasColumnName("NotificationTypeDetectingTarget")
                .HasColumnType("tinyint");

            builder.Property(t => t.AchievementConditionType)
                .IsRequired()
                .HasColumnName("AchievementConditionType")
                .HasColumnType("tinyint");

            builder.Property(t => t.AchievementConditionLevel)
                .IsRequired()
                .HasColumnName("AchievementConditionLevel")
                .HasColumnType("smallint");

            builder.Property(t => t.AchievementCondition)
                .IsRequired()
                .HasColumnName("AchievementCondition")
                .HasColumnType("int");

            builder.Property(t => t.RewardTarget)
                .IsRequired()
                .HasColumnName("RewardTarget")
                .HasColumnType("tinyint");

            builder.Property(t => t.GiveRewardDelayTime)
                .IsRequired()
                .HasColumnName("GiveRewardDelayTime")
                .HasColumnType("int");

            builder.Property(t => t.ActivateClientUI)
                .IsRequired()
                .HasColumnName("ActivateClientUI")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefServerEvent";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string DetectingTargetType = "DetectingTargetType";
            public const string DetectingTargetID = "DetectingTargetID";
            public const string Name = "Name";
            public const string BeginDate = "BeginDate";
            public const string EndDate = "EndDate";
            public const string NotificationTypeDetectingTarget = "NotificationTypeDetectingTarget";
            public const string AchievementConditionType = "AchievementConditionType";
            public const string AchievementConditionLevel = "AchievementConditionLevel";
            public const string AchievementCondition = "AchievementCondition";
            public const string RewardTarget = "RewardTarget";
            public const string GiveRewardDelayTime = "GiveRewardDelayTime";
            public const string ActivateClientUI = "ActivateClientUI";
        }
        #endregion
    }
}
