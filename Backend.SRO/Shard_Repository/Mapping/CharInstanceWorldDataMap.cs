using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class CharInstanceWorldDataMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.CharInstanceWorldData>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.CharInstanceWorldData> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_CharInstanceWorldData", "dbo");

            // key
            builder.HasKey(t => new { t.CharID, t.WorldID });

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.DungeonKeyID)
                .IsRequired()
                .HasColumnName("DungeonKeyID")
                .HasColumnType("int");

            builder.Property(t => t.WorldID)
                .IsRequired()
                .HasColumnName("WorldID")
                .HasColumnType("int");

            builder.Property(t => t.LayerID)
                .IsRequired()
                .HasColumnName("LayerID")
                .HasColumnType("int");

            builder.Property(t => t.OpenedTime)
                .IsRequired()
                .HasColumnName("OpenedTime")
                .HasColumnType("datetime");

            builder.Property(t => t.RegionID)
                .IsRequired()
                .HasColumnName("RegionID")
                .HasColumnType("smallint");

            builder.Property(t => t.PosX)
                .IsRequired()
                .HasColumnName("PosX")
                .HasColumnType("int");

            builder.Property(t => t.PosY)
                .IsRequired()
                .HasColumnName("PosY")
                .HasColumnType("int");

            builder.Property(t => t.PosZ)
                .IsRequired()
                .HasColumnName("PosZ")
                .HasColumnType("int");

            builder.Property(t => t.IsActivated)
                .IsRequired()
                .HasColumnName("IsActivated")
                .HasColumnType("tinyint");

            builder.Property(t => t.EnterCount)
                .IsRequired()
                .HasColumnName("EnterCount")
                .HasColumnType("int");

            builder.Property(t => t.LastEnterTime)
                .IsRequired()
                .HasColumnName("LastEnterTime")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_CharInstanceWorldData";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string DungeonKeyID = "DungeonKeyID";
            public const string WorldID = "WorldID";
            public const string LayerID = "LayerID";
            public const string OpenedTime = "OpenedTime";
            public const string RegionID = "RegionID";
            public const string PosX = "PosX";
            public const string PosY = "PosY";
            public const string PosZ = "PosZ";
            public const string IsActivated = "IsActivated";
            public const string EnterCount = "EnterCount";
            public const string LastEnterTime = "LastEnterTime";
        }
        #endregion
    }
}
