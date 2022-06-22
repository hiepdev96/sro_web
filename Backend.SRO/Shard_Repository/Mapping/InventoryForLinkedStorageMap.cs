using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class InventoryForLinkedStorageMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.InventoryForLinkedStorage>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.InventoryForLinkedStorage> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_InventoryForLinkedStorage", "dbo");

            // key
            builder.HasKey(t => new { t.LinkedItemID, t.Slot });

            // properties
            builder.Property(t => t.LinkedItemID)
                .IsRequired()
                .HasColumnName("LinkedItemID")
                .HasColumnType("bigint");

            builder.Property(t => t.Slot)
                .IsRequired()
                .HasColumnName("Slot")
                .HasColumnType("tinyint");

            builder.Property(t => t.ItemID)
                .IsRequired()
                .HasColumnName("ItemID")
                .HasColumnType("bigint");

            // relationships
            builder.HasOne(t => t.ItemItems)
                .WithMany(t => t.ItemInventoryForLinkedStorages)
                .HasForeignKey(d => d.ItemID)
                .HasConstraintName("FK__InventoryForLinkedStorage__Items");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_InventoryForLinkedStorage";
        }

        public struct Columns
        {
            public const string LinkedItemID = "LinkedItemID";
            public const string Slot = "Slot";
            public const string ItemID = "ItemID";
        }
        #endregion
    }
}
