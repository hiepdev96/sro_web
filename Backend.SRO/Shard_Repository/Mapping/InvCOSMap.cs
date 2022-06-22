using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class InvCOSMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.InvCOS>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.InvCOS> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_InvCOS", "dbo");

            // key
            builder.HasKey(t => new { t.Cosid, t.Slot });

            // properties
            builder.Property(t => t.Cosid)
                .IsRequired()
                .HasColumnName("COSID")
                .HasColumnType("int");

            builder.Property(t => t.Slot)
                .IsRequired()
                .HasColumnName("Slot")
                .HasColumnType("tinyint");

            builder.Property(t => t.ItemID)
                .HasColumnName("ItemID")
                .HasColumnType("bigint");

            // relationships
            builder.HasOne(t => t.CosidCharCOS)
                .WithMany(t => t.CosidInvCOs)
                .HasForeignKey(d => d.Cosid)
                .HasConstraintName("FK__InvCOS__CharCOS");

            builder.HasOne(t => t.ItemItems)
                .WithMany(t => t.ItemInvCOs)
                .HasForeignKey(d => d.ItemID)
                .HasConstraintName("FK__InvCOS__Items");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_InvCOS";
        }

        public struct Columns
        {
            public const string Cosid = "COSID";
            public const string Slot = "Slot";
            public const string ItemID = "ItemID";
        }
        #endregion
    }
}
