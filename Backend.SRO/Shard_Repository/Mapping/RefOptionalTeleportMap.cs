using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefOptionalTeleportMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefOptionalTeleport>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefOptionalTeleport> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefOptionalTeleport", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("int");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int");

            builder.Property(t => t.ObjName128)
                .IsRequired()
                .HasColumnName("ObjName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ZoneName128)
                .IsRequired()
                .HasColumnName("ZoneName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.RegionID)
                .IsRequired()
                .HasColumnName("RegionID")
                .HasColumnType("smallint");

            builder.Property(t => t.PosX)
                .IsRequired()
                .HasColumnName("Pos_X")
                .HasColumnType("smallint");

            builder.Property(t => t.PosY)
                .IsRequired()
                .HasColumnName("Pos_Y")
                .HasColumnType("smallint");

            builder.Property(t => t.PosZ)
                .IsRequired()
                .HasColumnName("Pos_Z")
                .HasColumnType("smallint");

            builder.Property(t => t.WorldID)
                .IsRequired()
                .HasColumnName("WorldID")
                .HasColumnType("smallint");

            builder.Property(t => t.RegionIDGroup)
                .IsRequired()
                .HasColumnName("RegionIDGroup")
                .HasColumnType("int");

            builder.Property(t => t.MapPoint)
                .IsRequired()
                .HasColumnName("MapPoint")
                .HasColumnType("tinyint");

            builder.Property(t => t.LevelMin)
                .IsRequired()
                .HasColumnName("LevelMin")
                .HasColumnType("smallint");

            builder.Property(t => t.LevelMax)
                .IsRequired()
                .HasColumnName("LevelMax")
                .HasColumnType("smallint");

            builder.Property(t => t.Param1)
                .HasColumnName("Param1")
                .HasColumnType("int");

            builder.Property(t => t.Param1Desc128)
                .HasColumnName("Param1_Desc_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param2)
                .HasColumnName("Param2")
                .HasColumnType("int");

            builder.Property(t => t.Param2Desc128)
                .HasColumnName("Param2_Desc_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Param3)
                .HasColumnName("Param3")
                .HasColumnType("int");

            builder.Property(t => t.Param3Desc128)
                .HasColumnName("Param3_Desc_128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefOptionalTeleport";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string ObjName128 = "ObjName128";
            public const string ZoneName128 = "ZoneName128";
            public const string RegionID = "RegionID";
            public const string PosX = "Pos_X";
            public const string PosY = "Pos_Y";
            public const string PosZ = "Pos_Z";
            public const string WorldID = "WorldID";
            public const string RegionIDGroup = "RegionIDGroup";
            public const string MapPoint = "MapPoint";
            public const string LevelMin = "LevelMin";
            public const string LevelMax = "LevelMax";
            public const string Param1 = "Param1";
            public const string Param1Desc128 = "Param1_Desc_128";
            public const string Param2 = "Param2";
            public const string Param2Desc128 = "Param2_Desc_128";
            public const string Param3 = "Param3";
            public const string Param3Desc128 = "Param3_Desc_128";
        }
        #endregion
    }
}
