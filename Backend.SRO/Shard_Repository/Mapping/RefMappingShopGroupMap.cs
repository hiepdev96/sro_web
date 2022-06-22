using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefMappingShopGroupMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefMappingShopGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefMappingShopGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefMappingShopGroup", "dbo");

            // key
            builder.HasKey(t => new { t.Country, t.RefShopGroupCodeName, t.RefShopCodeName });

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

            builder.Property(t => t.RefShopCodeName)
                .IsRequired()
                .HasColumnName("RefShopCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            builder.HasOne(t => t.CountryRefShopObject)
                .WithMany(t => t.CountryRefMappingShopGroups)
                .HasForeignKey(d => d.Country)
                .HasConstraintName("FK__RefMappingShopGroup__RefShopObject");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefMappingShopGroup";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Country = "Country";
            public const string RefShopGroupCodeName = "RefShopGroupCodeName";
            public const string RefShopCodeName = "RefShopCodeName";
        }
        #endregion
    }
}
