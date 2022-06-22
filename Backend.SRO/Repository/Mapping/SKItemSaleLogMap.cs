using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SKItemSaleLogMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SKItemSaleLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SKItemSaleLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SK_ItemSaleLog", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Jid)
                .IsRequired()
                .HasColumnName("JID")
                .HasColumnType("int");

            builder.Property(t => t.ShardID)
                .HasColumnName("ShardID")
                .HasColumnType("int");

            builder.Property(t => t.CharID)
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.ItemID)
                .HasColumnName("ItemID")
                .HasColumnType("int");

            builder.Property(t => t.SilkOwn)
                .IsRequired()
                .HasColumnName("Silk_Own")
                .HasColumnType("int");

            builder.Property(t => t.SilkGift)
                .IsRequired()
                .HasColumnName("Silk_Gift")
                .HasColumnType("int");

            builder.Property(t => t.SilkPoint)
                .IsRequired()
                .HasColumnName("Silk_Point")
                .HasColumnType("int");

            builder.Property(t => t.Ip)
                .HasColumnName("IP")
                .HasColumnType("int");

            builder.Property(t => t.RegDate)
                .IsRequired()
                .HasColumnName("RegDate")
                .HasColumnType("smalldatetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SK_ItemSaleLog";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string Jid = "JID";
            public const string ShardID = "ShardID";
            public const string CharID = "CharID";
            public const string ItemID = "ItemID";
            public const string SilkOwn = "Silk_Own";
            public const string SilkGift = "Silk_Gift";
            public const string SilkPoint = "Silk_Point";
            public const string Ip = "IP";
            public const string RegDate = "RegDate";
        }
        #endregion
    }
}
