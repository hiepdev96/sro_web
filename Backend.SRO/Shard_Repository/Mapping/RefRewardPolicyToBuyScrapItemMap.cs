using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefRewardPolicyToBuyScrapItemMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefRewardPolicyToBuyScrapItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefRewardPolicyToBuyScrapItem> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefRewardPolicyToBuyScrapItem", "dbo");

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

            builder.Property(t => t.Cash)
                .IsRequired()
                .HasColumnName("Cash")
                .HasColumnType("tinyint");

            builder.Property(t => t.TypeID1)
                .IsRequired()
                .HasColumnName("TypeID1")
                .HasColumnType("tinyint");

            builder.Property(t => t.TypeID2)
                .IsRequired()
                .HasColumnName("TypeID2")
                .HasColumnType("tinyint");

            builder.Property(t => t.TypeID3)
                .IsRequired()
                .HasColumnName("TypeID3")
                .HasColumnType("tinyint");

            builder.Property(t => t.TypeID4)
                .IsRequired()
                .HasColumnName("TypeID4")
                .HasColumnType("tinyint");

            builder.Property(t => t.RefItemCodeName)
                .IsRequired()
                .HasColumnName("RefItemCodeName")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129)
                .HasDefaultValueSql("(0)");

            builder.Property(t => t.AcceptOrReject)
                .IsRequired()
                .HasColumnName("AcceptOrReject")
                .HasColumnType("tinyint");

            builder.Property(t => t.FourCC)
                .IsRequired()
                .HasColumnName("FourCC")
                .HasColumnType("int");

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
                .WithMany(t => t.CountryRefRewardPolicyToBuyScrapItems)
                .HasForeignKey(d => d.Country)
                .HasConstraintName("FK__RefRewardPolicyToBuyScrapItem__RefShopObject");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefRewardPolicyToBuyScrapItem";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Country = "Country";
            public const string Cash = "Cash";
            public const string TypeID1 = "TypeID1";
            public const string TypeID2 = "TypeID2";
            public const string TypeID3 = "TypeID3";
            public const string TypeID4 = "TypeID4";
            public const string RefItemCodeName = "RefItemCodeName";
            public const string AcceptOrReject = "AcceptOrReject";
            public const string FourCC = "FourCC";
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
