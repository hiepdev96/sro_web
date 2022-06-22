using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefMappingShopWithTabMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefMappingShopWithTab>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefMappingShopWithTab> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefMappingShopWithTab", "dbo");

            // key
            builder.HasKey(t => new { t.Country, t.RefShopCodeName, t.RefTabGroupCodeName });

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Country)
                .IsRequired()
                .HasColumnName("Country")
                .HasColumnType("int");

            builder.Property(t => t.RefShopCodeName)
                .IsRequired()
                .HasColumnName("RefShopCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.RefTabGroupCodeName)
                .IsRequired()
                .HasColumnName("RefTabGroupCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            builder.HasOne(t => t.CountryRefShopObject)
                .WithMany(t => t.CountryRefMappingShopWithTabs)
                .HasForeignKey(d => d.Country)
                .HasConstraintName("FK__RefMappingShopWithTab__RefShopObject");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefMappingShopWithTab";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Country = "Country";
            public const string RefShopCodeName = "RefShopCodeName";
            public const string RefTabGroupCodeName = "RefTabGroupCodeName";
        }
        #endregion
    }
}
