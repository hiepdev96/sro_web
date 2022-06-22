using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class OpenMarketMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.OpenMarket>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.OpenMarket> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_OpenMarket", "dbo");

            // key
            builder.HasKey(t => t.Jid);

            // properties
            builder.Property(t => t.Jid)
                .IsRequired()
                .HasColumnName("JID")
                .HasColumnType("int");

            builder.Property(t => t.PersnalID)
                .IsRequired()
                .HasColumnName("PersnalID")
                .HasColumnType("int")
                .HasDefaultValueSql("((-1))");

            builder.Property(t => t.CharName16)
                .IsRequired()
                .HasColumnName("CharName16")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("tinyint");

            builder.Property(t => t.RefItemID)
                .IsRequired()
                .HasColumnName("RefItemID")
                .HasColumnType("int");

            builder.Property(t => t.TidGroupID)
                .IsRequired()
                .HasColumnName("TidGroupID")
                .HasColumnType("int");

            builder.Property(t => t.ItemClass)
                .IsRequired()
                .HasColumnName("ItemClass")
                .HasColumnType("int");

            builder.Property(t => t.ItemID)
                .IsRequired()
                .HasColumnName("ItemID")
                .HasColumnType("bigint");

            builder.Property(t => t.SellCnt)
                .IsRequired()
                .HasColumnName("SellCnt")
                .HasColumnType("int");

            builder.Property(t => t.RegDate)
                .IsRequired()
                .HasColumnName("RegDate")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.EndDate)
                .IsRequired()
                .HasColumnName("EndDate")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.Price)
                .IsRequired()
                .HasColumnName("Price")
                .HasColumnType("bigint");

            builder.Property(t => t.Deposit)
                .IsRequired()
                .HasColumnName("Deposit")
                .HasColumnType("bigint");

            builder.Property(t => t.SellFee)
                .IsRequired()
                .HasColumnName("SellFee")
                .HasColumnType("bigint");

            builder.Property(t => t.UseCash)
                .IsRequired()
                .HasColumnName("UseCash")
                .HasColumnType("int");

            builder.Property(t => t.Serial64)
                .IsRequired()
                .HasColumnName("Serial64")
                .HasColumnType("bigint");

            // relationships
            builder.HasOne(t => t.ItemItems)
                .WithMany(t => t.ItemOpenMarkets)
                .HasForeignKey(d => d.ItemID)
                .HasConstraintName("FK__OpenMarket__ItemID");

            builder.HasOne(t => t.AccountJID)
                .WithOne(t => t.OpenMarket)
                .HasForeignKey<VsroShard.Shard_Repository.Entities.OpenMarket>(d => d.Jid)
                .HasConstraintName("FK__OpenMarket__JID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_OpenMarket";
        }

        public struct Columns
        {
            public const string Jid = "JID";
            public const string PersnalID = "PersnalID";
            public const string CharName16 = "CharName16";
            public const string Status = "Status";
            public const string RefItemID = "RefItemID";
            public const string TidGroupID = "TidGroupID";
            public const string ItemClass = "ItemClass";
            public const string ItemID = "ItemID";
            public const string SellCnt = "SellCnt";
            public const string RegDate = "RegDate";
            public const string EndDate = "EndDate";
            public const string Price = "Price";
            public const string Deposit = "Deposit";
            public const string SellFee = "SellFee";
            public const string UseCash = "UseCash";
            public const string Serial64 = "Serial64";
        }
        #endregion
    }
}
