using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefShopTabMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefShopTab>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefShopTab> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefShopTab", "dbo");

            // key
            builder.HasKey(t => new { t.Country, t.Id });

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

            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.RefTabGroupCodeName)
                .IsRequired()
                .HasColumnName("RefTabGroupCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.StrID128Tab)
                .IsRequired()
                .HasColumnName("StrID128_Tab")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            builder.HasOne(t => t.CountryRefShopObject)
                .WithMany(t => t.CountryRefShopTabs)
                .HasForeignKey(d => d.Country)
                .HasConstraintName("FK__RefShopTab__RefShopObject");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefShopTab";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Country = "Country";
            public const string Id = "ID";
            public const string CodeName128 = "CodeName128";
            public const string RefTabGroupCodeName = "RefTabGroupCodeName";
            public const string StrID128Tab = "StrID128_Tab";
        }
        #endregion
    }
}
