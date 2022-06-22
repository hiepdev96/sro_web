using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class ResultOfPackageItemToMappingWithServerSideMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.ResultOfPackageItemToMappingWithServerSide>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.ResultOfPackageItemToMappingWithServerSide> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_ResultOfPackageItemToMappingWithServerSide", "dbo");

            // key
            builder.HasKey(t => new { t.CharID, t.Slot, t.RefItemSerial64, t.RefItemDBID });

            // properties
            builder.Property(t => t.Operation)
                .IsRequired()
                .HasColumnName("Operation")
                .HasColumnType("tinyint");

            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.Slot)
                .IsRequired()
                .HasColumnName("Slot")
                .HasColumnType("int");

            builder.Property(t => t.RefItemSerial64)
                .IsRequired()
                .HasColumnName("RefItemSerial64")
                .HasColumnType("bigint");

            builder.Property(t => t.RefItemDBID)
                .IsRequired()
                .HasColumnName("RefItemDBID")
                .HasColumnType("bigint");

            builder.Property(t => t.RefItemID)
                .IsRequired()
                .HasColumnName("RefItemID")
                .HasColumnType("int");

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("tinyint");

            builder.Property(t => t.SubType)
                .IsRequired()
                .HasColumnName("SubType")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_ResultOfPackageItemToMappingWithServerSide";
        }

        public struct Columns
        {
            public const string Operation = "Operation";
            public const string CharID = "CharID";
            public const string Slot = "Slot";
            public const string RefItemSerial64 = "RefItemSerial64";
            public const string RefItemDBID = "RefItemDBID";
            public const string RefItemID = "RefItemID";
            public const string Type = "Type";
            public const string SubType = "SubType";
        }
        #endregion
    }
}
