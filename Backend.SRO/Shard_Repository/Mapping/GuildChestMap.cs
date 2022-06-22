using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class GuildChestMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.GuildChest>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.GuildChest> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_GuildChest", "dbo");

            // key
            builder.HasKey(t => new { t.GuildID, t.Slot });

            // properties
            builder.Property(t => t.GuildID)
                .IsRequired()
                .HasColumnName("GuildID")
                .HasColumnType("int");

            builder.Property(t => t.Slot)
                .IsRequired()
                .HasColumnName("Slot")
                .HasColumnType("tinyint");

            builder.Property(t => t.ItemID)
                .HasColumnName("ItemID")
                .HasColumnType("bigint");

            // relationships
            builder.HasOne(t => t.Guild)
                .WithMany(t => t.GuildChests)
                .HasForeignKey(d => d.GuildID)
                .HasConstraintName("FK__GuildChest_Guild");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_GuildChest";
        }

        public struct Columns
        {
            public const string GuildID = "GuildID";
            public const string Slot = "Slot";
            public const string ItemID = "ItemID";
        }
        #endregion
    }
}
