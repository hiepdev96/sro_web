using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefHWANLevelMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefHWANLevel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefHWANLevel> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefHWANLevel", "dbo");

            // key
            builder.HasKey(t => t.HwanLevel);

            // properties
            builder.Property(t => t.HwanLevel)
                .IsRequired()
                .HasColumnName("HwanLevel")
                .HasColumnType("tinyint");

            builder.Property(t => t.ParamFourcc1)
                .HasColumnName("ParamFourcc1")
                .HasColumnType("int");

            builder.Property(t => t.ParamValue1)
                .HasColumnName("ParamValue1")
                .HasColumnType("tinyint");

            builder.Property(t => t.ParamFourcc2)
                .HasColumnName("ParamFourcc2")
                .HasColumnType("int");

            builder.Property(t => t.ParamValue2)
                .HasColumnName("ParamValue2")
                .HasColumnType("tinyint");

            builder.Property(t => t.ParamFourcc3)
                .HasColumnName("ParamFourcc3")
                .HasColumnType("int");

            builder.Property(t => t.ParamValue3)
                .HasColumnName("ParamValue3")
                .HasColumnType("tinyint");

            builder.Property(t => t.ParamFourcc4)
                .HasColumnName("ParamFourcc4")
                .HasColumnType("int");

            builder.Property(t => t.ParamValue4)
                .HasColumnName("ParamValue4")
                .HasColumnType("tinyint");

            builder.Property(t => t.ParamFourcc5)
                .HasColumnName("ParamFourcc5")
                .HasColumnType("int");

            builder.Property(t => t.ParamValue5)
                .HasColumnName("ParamValue5")
                .HasColumnType("tinyint");

            builder.Property(t => t.AssocFileObj128)
                .HasColumnName("AssocFileObj128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.TitleCH70)
                .HasColumnName("Title_CH70")
                .HasColumnType("varchar(70)")
                .HasMaxLength(70);

            builder.Property(t => t.TitleEU70)
                .HasColumnName("Title_EU70")
                .HasColumnType("varchar(70)")
                .HasMaxLength(70);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefHWANLevel";
        }

        public struct Columns
        {
            public const string HwanLevel = "HwanLevel";
            public const string ParamFourcc1 = "ParamFourcc1";
            public const string ParamValue1 = "ParamValue1";
            public const string ParamFourcc2 = "ParamFourcc2";
            public const string ParamValue2 = "ParamValue2";
            public const string ParamFourcc3 = "ParamFourcc3";
            public const string ParamValue3 = "ParamValue3";
            public const string ParamFourcc4 = "ParamFourcc4";
            public const string ParamValue4 = "ParamValue4";
            public const string ParamFourcc5 = "ParamFourcc5";
            public const string ParamValue5 = "ParamValue5";
            public const string AssocFileObj128 = "AssocFileObj128";
            public const string TitleCH70 = "Title_CH70";
            public const string TitleEU70 = "Title_EU70";
        }
        #endregion
    }
}
