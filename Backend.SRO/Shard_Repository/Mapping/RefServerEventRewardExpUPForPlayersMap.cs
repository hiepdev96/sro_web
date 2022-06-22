using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefServerEventRewardExpUPForPlayersMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefServerEventRewardExpUPForPlayers>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefServerEventRewardExpUPForPlayers> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefServerEventReward_ExpUPForPlayers", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.OwnerRewardID)
                .IsRequired()
                .HasColumnName("OwnerRewardID")
                .HasColumnType("int");

            builder.Property(t => t.ApplyTime)
                .IsRequired()
                .HasColumnName("ApplyTime")
                .HasColumnType("int");

            builder.Property(t => t.ApplyExpRatio)
                .IsRequired()
                .HasColumnName("ApplyExpRatio")
                .HasColumnType("tinyint");

            builder.Property(t => t.ApplySExpRatio)
                .IsRequired()
                .HasColumnName("ApplySExpRatio")
                .HasColumnType("tinyint");

            // relationships
            builder.HasOne(t => t.OwnerRefServerEventReward)
                .WithMany(t => t.OwnerRefServerEventRewardExpUPForPlayers)
                .HasForeignKey(d => d.OwnerRewardID)
                .HasConstraintName("FK__RefServerEventReward_ExpUPForPlayers__RefServerEventReward");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefServerEventReward_ExpUPForPlayers";
        }

        public struct Columns
        {
            public const string OwnerRewardID = "OwnerRewardID";
            public const string ApplyTime = "ApplyTime";
            public const string ApplyExpRatio = "ApplyExpRatio";
            public const string ApplySExpRatio = "ApplySExpRatio";
        }
        #endregion
    }
}
