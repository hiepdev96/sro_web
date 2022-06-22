using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefShopItemStockPeriodMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefShopItemStockPeriod>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefShopItemStockPeriod> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefShopItemStockPeriod", "dbo");

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

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

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

            builder.Property(t => t.StockOpeningDate)
                .IsRequired()
                .HasColumnName("StockOpeningDate")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.StockExpireDate)
                .IsRequired()
                .HasColumnName("StockExpireDate")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.PeriodDevice)
                .IsRequired()
                .HasColumnName("PeriodDevice")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefShopItemStockPeriod";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Country = "Country";
            public const string Id = "ID";
            public const string RefShopGroupCodeName = "RefShopGroupCodeName";
            public const string RefPackageItemCodeName = "RefPackageItemCodeName";
            public const string StockOpeningDate = "StockOpeningDate";
            public const string StockExpireDate = "StockExpireDate";
            public const string PeriodDevice = "PeriodDevice";
        }
        #endregion
    }
}
