using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefTeleport1Map
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefTeleport1>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefTeleport1> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefTeleport1", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("int");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int");

            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AssocRefObjCodeName128)
                .HasColumnName("AssocRefObjCodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.AssocRefObjID)
                .IsRequired()
                .HasColumnName("AssocRefObjID")
                .HasColumnType("int");

            builder.Property(t => t.ZoneName128)
                .IsRequired()
                .HasColumnName("ZoneName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.GenRegionID)
                .IsRequired()
                .HasColumnName("GenRegionID")
                .HasColumnType("smallint");

            builder.Property(t => t.GenPosX)
                .IsRequired()
                .HasColumnName("GenPos_X")
                .HasColumnType("smallint");

            builder.Property(t => t.GenPosY)
                .IsRequired()
                .HasColumnName("GenPos_Y")
                .HasColumnType("smallint");

            builder.Property(t => t.GenPosZ)
                .IsRequired()
                .HasColumnName("GenPos_Z")
                .HasColumnType("smallint");

            builder.Property(t => t.GenAreaRadius)
                .IsRequired()
                .HasColumnName("GenAreaRadius")
                .HasColumnType("smallint");

            builder.Property(t => t.CanBeResurrectPos)
                .IsRequired()
                .HasColumnName("CanBeResurrectPos")
                .HasColumnType("tinyint");

            builder.Property(t => t.CanGotoResurrectPos)
                .IsRequired()
                .HasColumnName("CanGotoResurrectPos")
                .HasColumnType("tinyint");

            builder.Property(t => t.GenWorldID)
                .IsRequired()
                .HasColumnName("GenWorldID")
                .HasColumnType("smallint");

            builder.Property(t => t.BindInteractionMask)
                .IsRequired()
                .HasColumnName("BindInteractionMask")
                .HasColumnType("tinyint");

            builder.Property(t => t.FixedService)
                .IsRequired()
                .HasColumnName("FixedService")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefTeleport1";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string CodeName128 = "CodeName128";
            public const string AssocRefObjCodeName128 = "AssocRefObjCodeName128";
            public const string AssocRefObjID = "AssocRefObjID";
            public const string ZoneName128 = "ZoneName128";
            public const string GenRegionID = "GenRegionID";
            public const string GenPosX = "GenPos_X";
            public const string GenPosY = "GenPos_Y";
            public const string GenPosZ = "GenPos_Z";
            public const string GenAreaRadius = "GenAreaRadius";
            public const string CanBeResurrectPos = "CanBeResurrectPos";
            public const string CanGotoResurrectPos = "CanGotoResurrectPos";
            public const string GenWorldID = "GenWorldID";
            public const string BindInteractionMask = "BindInteractionMask";
            public const string FixedService = "FixedService";
        }
        #endregion
    }
}
