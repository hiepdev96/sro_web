using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefShopTabGroupMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefShopTabGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefShopTabGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefShopTabGroup", "dbo");

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

            builder.Property(t => t.StrID128Group)
                .IsRequired()
                .HasColumnName("StrID128_Group")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            builder.HasOne(t => t.CountryRefShopObject)
                .WithMany(t => t.CountryRefShopTabGroups)
                .HasForeignKey(d => d.Country)
                .HasConstraintName("FK__RefShopTabGroup__RefShopObject1");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefShopTabGroup";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Country = "Country";
            public const string Id = "ID";
            public const string CodeName128 = "CodeName128";
            public const string StrID128Group = "StrID128_Group";
        }
        #endregion
    }
}
