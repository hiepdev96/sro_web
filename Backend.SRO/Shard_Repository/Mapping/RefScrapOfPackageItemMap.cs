using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefScrapOfPackageItemMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefScrapOfPackageItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefScrapOfPackageItem> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefScrapOfPackageItem", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Country)
                .IsRequired()
                .HasColumnName("Country")
                .HasColumnType("int");

            builder.Property(t => t.RefPackageItemCodeName)
                .IsRequired()
                .HasColumnName("RefPackageItemCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.RefItemCodeName)
                .IsRequired()
                .HasColumnName("RefItemCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.OptLevel)
                .IsRequired()
                .HasColumnName("OptLevel")
                .HasColumnType("tinyint");

            builder.Property(t => t.Variance)
                .IsRequired()
                .HasColumnName("Variance")
                .HasColumnType("bigint");

            builder.Property(t => t.Data)
                .IsRequired()
                .HasColumnName("Data")
                .HasColumnType("int");

            builder.Property(t => t.MagParamNum)
                .IsRequired()
                .HasColumnName("MagParamNum")
                .HasColumnType("tinyint");

            builder.Property(t => t.MagParam1)
                .IsRequired()
                .HasColumnName("MagParam1")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam2)
                .IsRequired()
                .HasColumnName("MagParam2")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam3)
                .IsRequired()
                .HasColumnName("MagParam3")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam4)
                .IsRequired()
                .HasColumnName("MagParam4")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam5)
                .IsRequired()
                .HasColumnName("MagParam5")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam6)
                .IsRequired()
                .HasColumnName("MagParam6")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam7)
                .IsRequired()
                .HasColumnName("MagParam7")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam8)
                .IsRequired()
                .HasColumnName("MagParam8")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam9)
                .IsRequired()
                .HasColumnName("MagParam9")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam10)
                .IsRequired()
                .HasColumnName("MagParam10")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam11)
                .IsRequired()
                .HasColumnName("MagParam11")
                .HasColumnType("bigint");

            builder.Property(t => t.MagParam12)
                .IsRequired()
                .HasColumnName("MagParam12")
                .HasColumnType("bigint");

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

            builder.Property(t => t.Index)
                .IsRequired()
                .HasColumnName("Index")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            // relationships
            builder.HasOne(t => t.CountryRefShopObject)
                .WithMany(t => t.CountryRefScrapOfPackageItems)
                .HasForeignKey(d => d.Country)
                .HasConstraintName("FK___RefScrap__Count__125D4E50");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefScrapOfPackageItem";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Country = "Country";
            public const string RefPackageItemCodeName = "RefPackageItemCodeName";
            public const string RefItemCodeName = "RefItemCodeName";
            public const string OptLevel = "OptLevel";
            public const string Variance = "Variance";
            public const string Data = "Data";
            public const string MagParamNum = "MagParamNum";
            public const string MagParam1 = "MagParam1";
            public const string MagParam2 = "MagParam2";
            public const string MagParam3 = "MagParam3";
            public const string MagParam4 = "MagParam4";
            public const string MagParam5 = "MagParam5";
            public const string MagParam6 = "MagParam6";
            public const string MagParam7 = "MagParam7";
            public const string MagParam8 = "MagParam8";
            public const string MagParam9 = "MagParam9";
            public const string MagParam10 = "MagParam10";
            public const string MagParam11 = "MagParam11";
            public const string MagParam12 = "MagParam12";
            public const string Param1 = "Param1";
            public const string Param1Desc128 = "Param1_Desc128";
            public const string Param2 = "Param2";
            public const string Param2Desc128 = "Param2_Desc128";
            public const string Param3 = "Param3";
            public const string Param3Desc128 = "Param3_Desc128";
            public const string Param4 = "Param4";
            public const string Param4Desc128 = "Param4_Desc128";
            public const string Index = "Index";
        }
        #endregion
    }
}
