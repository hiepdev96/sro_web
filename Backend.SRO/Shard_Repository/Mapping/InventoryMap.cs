using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class InventoryMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.Inventory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.Inventory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_Inventory", "dbo");

            // key
            builder.HasKey(t => new { t.CharID, t.Slot });

            // properties
            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.Slot)
                .IsRequired()
                .HasColumnName("Slot")
                .HasColumnType("tinyint");

            builder.Property(t => t.ItemID)
                .IsRequired()
                .HasColumnName("ItemID")
                .HasColumnType("bigint");

            // relationships
            builder.HasOne(t => t.Char)
                .WithMany(t => t.Inventories)
                .HasForeignKey(d => d.CharID)
                .HasConstraintName("FK__Inventory__Char");

            builder.HasOne(t => t.ItemItems)
                .WithMany(t => t.ItemInventories)
                .HasForeignKey(d => d.ItemID)
                .HasConstraintName("FK__Inventory__Items");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_Inventory";
        }

        public struct Columns
        {
            public const string CharID = "CharID";
            public const string Slot = "Slot";
            public const string ItemID = "ItemID";
        }
        #endregion
    }
}
