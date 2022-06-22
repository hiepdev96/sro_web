using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TrijobRewardsMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TrijobRewards>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TrijobRewards> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_TrijobRewards", "dbo");

            // key
            builder.HasKey(t => t.JobType);

            // properties
            builder.Property(t => t.JobType)
                .IsRequired()
                .HasColumnName("JobType")
                .HasColumnType("tinyint");

            builder.Property(t => t.Reward)
                .IsRequired()
                .HasColumnName("Reward")
                .HasColumnType("bigint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_TrijobRewards";
        }

        public struct Columns
        {
            public const string JobType = "JobType";
            public const string Reward = "Reward";
        }
        #endregion
    }
}
