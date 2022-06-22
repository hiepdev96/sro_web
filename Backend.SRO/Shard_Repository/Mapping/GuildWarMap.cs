using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class GuildWarMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.GuildWar>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.GuildWar> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_GuildWar", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.WarType)
                .IsRequired()
                .HasColumnName("WarType")
                .HasColumnType("tinyint");

            builder.Property(t => t.VictoryPointIndex)
                .IsRequired()
                .HasColumnName("VictoryPointIndex")
                .HasColumnType("tinyint");

            builder.Property(t => t.LodgedGold)
                .IsRequired()
                .HasColumnName("LodgedGold")
                .HasColumnType("int");

            builder.Property(t => t.WarEndTime)
                .HasColumnName("WarEndTime")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.Guild1)
                .IsRequired()
                .HasColumnName("Guild1")
                .HasColumnType("int");

            builder.Property(t => t.Guild2)
                .IsRequired()
                .HasColumnName("Guild2")
                .HasColumnType("int");

            builder.Property(t => t.PointGain1)
                .IsRequired()
                .HasColumnName("PointGain1")
                .HasColumnType("int");

            builder.Property(t => t.PointGain2)
                .IsRequired()
                .HasColumnName("PointGain2")
                .HasColumnType("int");

            builder.Property(t => t.Data1)
                .IsRequired()
                .HasColumnName("Data1")
                .HasColumnType("int");

            builder.Property(t => t.Data2)
                .IsRequired()
                .HasColumnName("Data2")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Guild)
                .WithMany(t => t.GuildWars)
                .HasForeignKey(d => d.Guild1)
                .HasConstraintName("FK__GuildWar__Guild");

            builder.HasOne(t => t.Guild3)
                .WithMany(t => t.GuildWars1)
                .HasForeignKey(d => d.Guild2)
                .HasConstraintName("FK__GuildWar__Guild1");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_GuildWar";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string WarType = "WarType";
            public const string VictoryPointIndex = "VictoryPointIndex";
            public const string LodgedGold = "LodgedGold";
            public const string WarEndTime = "WarEndTime";
            public const string Guild1 = "Guild1";
            public const string Guild2 = "Guild2";
            public const string PointGain1 = "PointGain1";
            public const string PointGain2 = "PointGain2";
            public const string Data1 = "Data1";
            public const string Data2 = "Data2";
        }
        #endregion
    }
}
