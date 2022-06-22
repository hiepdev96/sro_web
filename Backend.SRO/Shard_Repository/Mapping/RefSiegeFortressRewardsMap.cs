using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSiegeFortressRewardsMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSiegeFortressRewards>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSiegeFortressRewards> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSiegeFortressRewards", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int");

            builder.Property(t => t.RewardTypeID)
                .IsRequired()
                .HasColumnName("RewardTypeID")
                .HasColumnType("tinyint");

            builder.Property(t => t.RewardValue)
                .IsRequired()
                .HasColumnName("RewardValue")
                .HasColumnType("int");

            builder.Property(t => t.RewardCount)
                .IsRequired()
                .HasColumnName("RewardCount")
                .HasColumnType("tinyint");

            // relationships
            builder.HasOne(t => t.RefSiegeFortress)
                .WithMany(t => t.RefSiegeFortressRewards)
                .HasForeignKey(d => d.FortressID)
                .HasConstraintName("FK__RefSiegeFortressRewards_FortressID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSiegeFortressRewards";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string FortressID = "FortressID";
            public const string RewardTypeID = "RewardTypeID";
            public const string RewardValue = "RewardValue";
            public const string RewardCount = "RewardCount";
        }
        #endregion
    }
}
