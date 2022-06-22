using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class FleaMarketNetworkMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.FleaMarketNetwork>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.FleaMarketNetwork> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_FleaMarketNetwork", "dbo");

            // key
            builder.HasKey(t => t.CharID);

            // properties
            builder.Property(t => t.AbleOpen)
                .IsRequired()
                .HasColumnName("AbleOpen")
                .HasColumnType("tinyint");

            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.Slot)
                .IsRequired()
                .HasColumnName("Slot")
                .HasColumnType("tinyint");

            builder.Property(t => t.TidGroupID)
                .IsRequired()
                .HasColumnName("TidGroupID")
                .HasColumnType("int");

            builder.Property(t => t.ItemClass)
                .IsRequired()
                .HasColumnName("ItemClass")
                .HasColumnType("tinyint");

            builder.Property(t => t.ItemCount)
                .IsRequired()
                .HasColumnName("ItemCount")
                .HasColumnType("int");

            builder.Property(t => t.MakeZone)
                .IsRequired()
                .HasColumnName("MakeZone")
                .HasColumnType("tinyint");

            builder.Property(t => t.Cash)
                .IsRequired()
                .HasColumnName("Cash")
                .HasColumnType("bigint");

            // relationships
            builder.HasOne(t => t.Char)
                .WithOne(t => t.FleaMarketNetwork)
                .HasForeignKey<VsroShard.Shard_Repository.Entities.FleaMarketNetwork>(d => d.CharID)
                .HasConstraintName("FK__FleaMarketNetwork__Char");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_FleaMarketNetwork";
        }

        public struct Columns
        {
            public const string AbleOpen = "AbleOpen";
            public const string CharID = "CharID";
            public const string Slot = "Slot";
            public const string TidGroupID = "TidGroupID";
            public const string ItemClass = "ItemClass";
            public const string ItemCount = "ItemCount";
            public const string MakeZone = "MakeZone";
            public const string Cash = "Cash";
        }
        #endregion
    }
}
