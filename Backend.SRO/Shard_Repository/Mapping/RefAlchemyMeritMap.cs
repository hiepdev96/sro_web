using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefAlchemyMeritMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefAlchemyMerit>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefAlchemyMerit> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefAlchemyMerit", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("int");

            builder.Property(t => t.Group)
                .IsRequired()
                .HasColumnName("Group")
                .HasColumnType("tinyint");

            builder.Property(t => t.OptName128)
                .IsRequired()
                .HasColumnName("OptName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Level)
                .IsRequired()
                .HasColumnName("Level")
                .HasColumnType("tinyint");

            builder.Property(t => t.Weapon)
                .IsRequired()
                .HasColumnName("Weapon")
                .HasColumnType("real");

            builder.Property(t => t.Armor)
                .IsRequired()
                .HasColumnName("Armor")
                .HasColumnType("real");

            builder.Property(t => t.Accessory)
                .IsRequired()
                .HasColumnName("Accessory")
                .HasColumnType("real");

            builder.Property(t => t.Shield)
                .IsRequired()
                .HasColumnName("Shield")
                .HasColumnType("real");

            builder.Property(t => t.FreeParam1)
                .HasColumnName("FreeParam1")
                .HasColumnType("bigint");

            builder.Property(t => t.FreeParamDesc1)
                .HasColumnName("FreeParamDesc1")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.FreeParam2)
                .HasColumnName("FreeParam2")
                .HasColumnType("bigint");

            builder.Property(t => t.FreeParamDesc2)
                .HasColumnName("FreeParamDesc2")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.FreeParam3)
                .HasColumnName("FreeParam3")
                .HasColumnType("bigint");

            builder.Property(t => t.FreeParamDesc3)
                .HasColumnName("FreeParamDesc3")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefAlchemyMerit";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Group = "Group";
            public const string OptName128 = "OptName128";
            public const string Level = "Level";
            public const string Weapon = "Weapon";
            public const string Armor = "Armor";
            public const string Accessory = "Accessory";
            public const string Shield = "Shield";
            public const string FreeParam1 = "FreeParam1";
            public const string FreeParamDesc1 = "FreeParamDesc1";
            public const string FreeParam2 = "FreeParam2";
            public const string FreeParamDesc2 = "FreeParamDesc2";
            public const string FreeParam3 = "FreeParam3";
            public const string FreeParamDesc3 = "FreeParamDesc3";
        }
        #endregion
    }
}
