using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefShopGoodsMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefShopGoods>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefShopGoods> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefShopGoods", "dbo");

            // key
            builder.HasKey(t => new { t.Country, t.RefTabCodeName, t.RefPackageItemCodeName });

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Country)
                .IsRequired()
                .HasColumnName("Country")
                .HasColumnType("int");

            builder.Property(t => t.RefTabCodeName)
                .IsRequired()
                .HasColumnName("RefTabCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.RefPackageItemCodeName)
                .IsRequired()
                .HasColumnName("RefPackageItemCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.SlotIndex)
                .IsRequired()
                .HasColumnName("SlotIndex")
                .HasColumnType("tinyint");

            builder.Property(t => t.Param1)
                .IsRequired()
                .HasColumnName("Param1")
                .HasColumnType("int");

            builder.Property(t => t.Param1Desc128)
                .IsRequired()
                .HasColumnName("Param1_Desc128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129)
                .HasDefaultValueSql("('xxx')");

            builder.Property(t => t.Param2)
                .IsRequired()
                .HasColumnName("Param2")
                .HasColumnType("int");

            builder.Property(t => t.Param2Desc128)
                .IsRequired()
                .HasColumnName("Param2_Desc128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129)
                .HasDefaultValueSql("('xxx')");

            builder.Property(t => t.Param3)
                .IsRequired()
                .HasColumnName("Param3")
                .HasColumnType("int");

            builder.Property(t => t.Param3Desc128)
                .IsRequired()
                .HasColumnName("Param3_Desc128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129)
                .HasDefaultValueSql("('xxx')");

            builder.Property(t => t.Param4)
                .IsRequired()
                .HasColumnName("Param4")
                .HasColumnType("int");

            builder.Property(t => t.Param4Desc128)
                .IsRequired()
                .HasColumnName("Param4_Desc128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129)
                .HasDefaultValueSql("('xxx')");

            // relationships
            builder.HasOne(t => t.CountryRefShopObject)
                .WithMany(t => t.CountryRefShopGoods)
                .HasForeignKey(d => d.Country)
                .HasConstraintName("FK___RefShopG__Count__13517289");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefShopGoods";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Country = "Country";
            public const string RefTabCodeName = "RefTabCodeName";
            public const string RefPackageItemCodeName = "RefPackageItemCodeName";
            public const string SlotIndex = "SlotIndex";
            public const string Param1 = "Param1";
            public const string Param1Desc128 = "Param1_Desc128";
            public const string Param2 = "Param2";
            public const string Param2Desc128 = "Param2_Desc128";
            public const string Param3 = "Param3";
            public const string Param3Desc128 = "Param3_Desc128";
            public const string Param4 = "Param4";
            public const string Param4Desc128 = "Param4_Desc128";
        }
        #endregion
    }
}
