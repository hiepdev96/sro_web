using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class ServerEventRewardMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.ServerEventReward>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.ServerEventReward> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_ServerEventReward", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.ServerEventID)
                .IsRequired()
                .HasColumnName("ServerEventID")
                .HasColumnType("int");

            builder.Property(t => t.RewardID)
                .IsRequired()
                .HasColumnName("RewardID")
                .HasColumnType("int");

            builder.Property(t => t.RemainRewardTime)
                .IsRequired()
                .HasColumnName("RemainRewardTime")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_ServerEventReward";
        }

        public struct Columns
        {
            public const string ServerEventID = "ServerEventID";
            public const string RewardID = "RewardID";
            public const string RemainRewardTime = "RemainRewardTime";
        }
        #endregion
    }
}
