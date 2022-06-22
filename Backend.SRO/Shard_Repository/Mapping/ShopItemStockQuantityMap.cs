using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class ShopItemStockQuantityMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.ShopItemStockQuantity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.ShopItemStockQuantity> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_ShopItemStockQuantity", "dbo");

            // key
            builder.HasKey(t => new { t.Country, t.RefShopGroupCodeName, t.RefPackageItemCodeName });

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Country)
                .IsRequired()
                .HasColumnName("Country")
                .HasColumnType("int");

            builder.Property(t => t.RefShopGroupCodeName)
                .IsRequired()
                .HasColumnName("RefShopGroupCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.RefPackageItemCodeName)
                .IsRequired()
                .HasColumnName("RefPackageItemCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ConstStockQuantity)
                .IsRequired()
                .HasColumnName("ConstStockQuantity")
                .HasColumnType("smallint");

            builder.Property(t => t.StockQuantity)
                .IsRequired()
                .HasColumnName("StockQuantity")
                .HasColumnType("smallint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_ShopItemStockQuantity";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Country = "Country";
            public const string RefShopGroupCodeName = "RefShopGroupCodeName";
            public const string RefPackageItemCodeName = "RefPackageItemCodeName";
            public const string ConstStockQuantity = "ConstStockQuantity";
            public const string StockQuantity = "StockQuantity";
        }
        #endregion
    }
}
