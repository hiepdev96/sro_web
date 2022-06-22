using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SiegeFortressStatusMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SiegeFortressStatus>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SiegeFortressStatus> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("__SiegeFortressStatus__", "dbo");

            // key
            builder.HasKey(t => new { t.ShardID, t.FortressName });

            // properties
            builder.Property(t => t.ShardID)
                .IsRequired()
                .HasColumnName("ShardID")
                .HasColumnType("int");

            builder.Property(t => t.FortressName)
                .IsRequired()
                .HasColumnName("FortressName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.FortressScale)
                .IsRequired()
                .HasColumnName("FortressScale")
                .HasColumnType("tinyint");

            builder.Property(t => t.TaxRatio)
                .IsRequired()
                .HasColumnName("TaxRatio")
                .HasColumnType("smallint");

            builder.Property(t => t.OwnerGuildName)
                .HasColumnName("OwnerGuildName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.OwnerGuildMaster)
                .HasColumnName("OwnerGuildMaster")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.OwnerAllianceGuildName1)
                .HasColumnName("OwnerAllianceGuildName1")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.OwnerAllianceGuildName2)
                .HasColumnName("OwnerAllianceGuildName2")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.OwnerAllianceGuildName3)
                .HasColumnName("OwnerAllianceGuildName3")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.OwnerAllianceGuildName4)
                .HasColumnName("OwnerAllianceGuildName4")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.OwnerAllianceGuildName5)
                .HasColumnName("OwnerAllianceGuildName5")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.OwnerAllianceGuildName6)
                .HasColumnName("OwnerAllianceGuildName6")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.OwnerAllianceGuildName7)
                .HasColumnName("OwnerAllianceGuildName7")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.OwnerAllianceGuildName8)
                .HasColumnName("OwnerAllianceGuildName8")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.OwnerUpdateDate)
                .HasColumnName("OwnerUpdateDate")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "__SiegeFortressStatus__";
        }

        public struct Columns
        {
            public const string ShardID = "ShardID";
            public const string FortressName = "FortressName";
            public const string FortressScale = "FortressScale";
            public const string TaxRatio = "TaxRatio";
            public const string OwnerGuildName = "OwnerGuildName";
            public const string OwnerGuildMaster = "OwnerGuildMaster";
            public const string OwnerAllianceGuildName1 = "OwnerAllianceGuildName1";
            public const string OwnerAllianceGuildName2 = "OwnerAllianceGuildName2";
            public const string OwnerAllianceGuildName3 = "OwnerAllianceGuildName3";
            public const string OwnerAllianceGuildName4 = "OwnerAllianceGuildName4";
            public const string OwnerAllianceGuildName5 = "OwnerAllianceGuildName5";
            public const string OwnerAllianceGuildName6 = "OwnerAllianceGuildName6";
            public const string OwnerAllianceGuildName7 = "OwnerAllianceGuildName7";
            public const string OwnerAllianceGuildName8 = "OwnerAllianceGuildName8";
            public const string OwnerUpdateDate = "OwnerUpdateDate";
        }
        #endregion
    }
}
