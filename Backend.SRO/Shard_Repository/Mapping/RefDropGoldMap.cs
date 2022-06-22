using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefDropGoldMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefDropGold>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefDropGold> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefDropGold", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.MonLevel)
                .IsRequired()
                .HasColumnName("MonLevel")
                .HasColumnType("tinyint");

            builder.Property(t => t.DropProb)
                .IsRequired()
                .HasColumnName("DropProb")
                .HasColumnType("real");

            builder.Property(t => t.GoldMin)
                .IsRequired()
                .HasColumnName("GoldMin")
                .HasColumnType("int");

            builder.Property(t => t.GoldMax)
                .IsRequired()
                .HasColumnName("GoldMax")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefDropGold";
        }

        public struct Columns
        {
            public const string MonLevel = "MonLevel";
            public const string DropProb = "DropProb";
            public const string GoldMin = "GoldMin";
            public const string GoldMax = "GoldMax";
        }
        #endregion
    }
}
