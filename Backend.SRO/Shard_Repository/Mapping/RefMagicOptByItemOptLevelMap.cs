using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefMagicOptByItemOptLevelMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefMagicOptByItemOptLevel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefMagicOptByItemOptLevel> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefMagicOptByItemOptLevel", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Link)
                .IsRequired()
                .HasColumnName("Link")
                .HasColumnType("int");

            builder.Property(t => t.RefMagicOptID)
                .IsRequired()
                .HasColumnName("RefMagicOptID")
                .HasColumnType("smallint");

            builder.Property(t => t.MagicOptValue)
                .IsRequired()
                .HasColumnName("MagicOptValue")
                .HasColumnType("int");

            builder.Property(t => t.TooltipType)
                .IsRequired()
                .HasColumnName("TooltipType")
                .HasColumnType("tinyint");

            builder.Property(t => t.TooltipCodename)
                .IsRequired()
                .HasColumnName("TooltipCodename")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128)
                .HasDefaultValueSql("('xxx')");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefMagicOptByItemOptLevel";
        }

        public struct Columns
        {
            public const string Link = "Link";
            public const string RefMagicOptID = "RefMagicOptID";
            public const string MagicOptValue = "MagicOptValue";
            public const string TooltipType = "TooltipType";
            public const string TooltipCodename = "TooltipCodename";
        }
        #endregion
    }
}
