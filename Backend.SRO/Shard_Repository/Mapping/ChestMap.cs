using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class ChestMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.Chest>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.Chest> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_Chest", "dbo");

            // key
            builder.HasKey(t => new { t.UserJID, t.Slot });

            // properties
            builder.Property(t => t.UserJID)
                .IsRequired()
                .HasColumnName("UserJID")
                .HasColumnType("int");

            builder.Property(t => t.Slot)
                .IsRequired()
                .HasColumnName("Slot")
                .HasColumnType("tinyint");

            builder.Property(t => t.ItemID)
                .HasColumnName("ItemID")
                .HasColumnType("bigint");

            // relationships
            builder.HasOne(t => t.ItemItems)
                .WithMany(t => t.ItemChests)
                .HasForeignKey(d => d.ItemID)
                .HasConstraintName("FK__Chest__Items");

            builder.HasOne(t => t.UserJAccountJID)
                .WithMany(t => t.UserJChests)
                .HasForeignKey(d => d.UserJID)
                .HasConstraintName("FK__Chest__User");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_Chest";
        }

        public struct Columns
        {
            public const string UserJID = "UserJID";
            public const string Slot = "Slot";
            public const string ItemID = "ItemID";
        }
        #endregion
    }
}
