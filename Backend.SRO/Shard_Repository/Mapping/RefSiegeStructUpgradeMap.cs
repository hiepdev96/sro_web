using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSiegeStructUpgradeMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSiegeStructUpgrade>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSiegeStructUpgrade> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSiegeStructUpgrade", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Structname)
                .IsRequired()
                .HasColumnName("Structname")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.BaseStructcodename)
                .IsRequired()
                .HasColumnName("BaseStructcodename")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.UpgradeStructname1)
                .IsRequired()
                .HasColumnName("UpgradeStructname1")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.UpgradeStructname2)
                .IsRequired()
                .HasColumnName("UpgradeStructname2")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.UpgradeStructname3)
                .IsRequired()
                .HasColumnName("UpgradeStructname3")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.UpgradeStructname4)
                .IsRequired()
                .HasColumnName("UpgradeStructname4")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSiegeStructUpgrade";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Structname = "Structname";
            public const string BaseStructcodename = "BaseStructcodename";
            public const string UpgradeStructname1 = "UpgradeStructname1";
            public const string UpgradeStructname2 = "UpgradeStructname2";
            public const string UpgradeStructname3 = "UpgradeStructname3";
            public const string UpgradeStructname4 = "UpgradeStructname4";
        }
        #endregion
    }
}
