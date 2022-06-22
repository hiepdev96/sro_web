using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefServerEventRewardSpawnMonsterMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefServerEventRewardSpawnMonster>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefServerEventRewardSpawnMonster> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefServerEventReward_SpawnMonster", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.OwnerRewardID)
                .IsRequired()
                .HasColumnName("OwnerRewardID")
                .HasColumnType("int");

            builder.Property(t => t.RegionID)
                .IsRequired()
                .HasColumnName("RegionID")
                .HasColumnType("int");

            builder.Property(t => t.PosX)
                .IsRequired()
                .HasColumnName("PosX")
                .HasColumnType("real");

            builder.Property(t => t.PosY)
                .IsRequired()
                .HasColumnName("PosY")
                .HasColumnType("real");

            builder.Property(t => t.PosZ)
                .IsRequired()
                .HasColumnName("PosZ")
                .HasColumnType("real");

            // relationships
            builder.HasOne(t => t.OwnerRefServerEventReward)
                .WithMany(t => t.OwnerRefServerEventRewardSpawnMonsters)
                .HasForeignKey(d => d.OwnerRewardID)
                .HasConstraintName("FK__RefServerEventReward_SpawnMonster__RefServerEventReward");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefServerEventReward_SpawnMonster";
        }

        public struct Columns
        {
            public const string OwnerRewardID = "OwnerRewardID";
            public const string RegionID = "RegionID";
            public const string PosX = "PosX";
            public const string PosY = "PosY";
            public const string PosZ = "PosZ";
        }
        #endregion
    }
}
