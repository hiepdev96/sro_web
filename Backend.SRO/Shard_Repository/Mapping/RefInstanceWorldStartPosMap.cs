using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefInstanceWorldStartPosMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefInstanceWorldStartPos>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefInstanceWorldStartPos> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefInstance_World_Start_Pos", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.WorldID)
                .IsRequired()
                .HasColumnName("WorldID")
                .HasColumnType("int");

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

            builder.Property(t => t.Param)
                .HasColumnName("Param")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefInstance_World_Start_Pos";
        }

        public struct Columns
        {
            public const string WorldID = "WorldID";
            public const string RegionID = "RegionID";
            public const string PosX = "PosX";
            public const string PosY = "PosY";
            public const string PosZ = "PosZ";
            public const string Param = "Param";
        }
        #endregion
    }
}
