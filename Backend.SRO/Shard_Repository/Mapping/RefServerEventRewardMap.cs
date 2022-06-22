using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefServerEventRewardMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefServerEventReward>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefServerEventReward> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefServerEventReward", "dbo");

            // key
            builder.HasKey(t => t.RewardID);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.RewardID)
                .IsRequired()
                .HasColumnName("RewardID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.OwnerServerEventID)
                .IsRequired()
                .HasColumnName("OwnerServerEventID")
                .HasColumnType("int");

            builder.Property(t => t.RefRewardID)
                .IsRequired()
                .HasColumnName("RefRewardID")
                .HasColumnType("int");

            builder.Property(t => t.Quantity)
                .IsRequired()
                .HasColumnName("Quantity")
                .HasColumnType("tinyint");

            builder.Property(t => t.RewardClass)
                .IsRequired()
                .HasColumnName("RewardClass")
                .HasColumnType("tinyint");

            builder.Property(t => t.MasterReward)
                .IsRequired()
                .HasColumnName("MasterReward")
                .HasColumnType("tinyint");

            // relationships
            builder.HasOne(t => t.OwnerServerEventRefServerEvent)
                .WithMany(t => t.OwnerServerEventRefServerEventRewards)
                .HasForeignKey(d => d.OwnerServerEventID)
                .HasConstraintName("FK__RefServerEventReward__RefServerEvent");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefServerEventReward";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string RewardID = "RewardID";
            public const string OwnerServerEventID = "OwnerServerEventID";
            public const string RefRewardID = "RefRewardID";
            public const string Quantity = "Quantity";
            public const string RewardClass = "RewardClass";
            public const string MasterReward = "MasterReward";
        }
        #endregion
    }
}
