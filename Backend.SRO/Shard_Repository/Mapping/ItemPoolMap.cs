using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class ItemPoolMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.ItemPool>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.ItemPool> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_ItemPool", "dbo");

            // key
            builder.HasKey(t => t.ItemID);

            // properties
            builder.Property(t => t.ItemID)
                .IsRequired()
                .HasColumnName("ItemID")
                .HasColumnType("bigint");

            builder.Property(t => t.InUse)
                .IsRequired()
                .HasColumnName("InUse")
                .HasColumnType("tinyint");

            // relationships
            builder.HasOne(t => t.ItemItems)
                .WithOne(t => t.ItemItemPool)
                .HasForeignKey<VsroShard.Shard_Repository.Entities.ItemPool>(d => d.ItemID)
                .HasConstraintName("FK__ItemPool__Items");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_ItemPool";
        }

        public struct Columns
        {
            public const string ItemID = "ItemID";
            public const string InUse = "InUse";
        }
        #endregion
    }
}
