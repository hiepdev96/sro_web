using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class SKSilkGoodsMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.SKSilkGoods>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.SKSilkGoods> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SK_SilkGoods", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.GoodsCode)
                .IsRequired()
                .HasColumnName("GoodsCode")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.GoodsName)
                .IsRequired()
                .HasColumnName("GoodsName")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.SilkQuantity)
                .IsRequired()
                .HasColumnName("SilkQuantity")
                .HasColumnType("int");

            builder.Property(t => t.PointQuantity)
                .IsRequired()
                .HasColumnName("PointQuantity")
                .HasColumnType("int");

            builder.Property(t => t.SilkPrice)
                .IsRequired()
                .HasColumnName("SilkPrice")
                .HasColumnType("int");

            builder.Property(t => t.Category)
                .IsRequired()
                .HasColumnName("Category")
                .HasColumnType("tinyint");

            builder.Property(t => t.CPName)
                .IsRequired()
                .HasColumnName("CPName")
                .HasColumnType("varchar(36)")
                .HasMaxLength(36);

            builder.Property(t => t.RegDate)
                .IsRequired()
                .HasColumnName("RegDate")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SK_SilkGoods";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string GoodsCode = "GoodsCode";
            public const string GoodsName = "GoodsName";
            public const string SilkQuantity = "SilkQuantity";
            public const string PointQuantity = "PointQuantity";
            public const string SilkPrice = "SilkPrice";
            public const string Category = "Category";
            public const string CPName = "CPName";
            public const string RegDate = "RegDate";
        }
        #endregion
    }
}
