using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class BindingOptionWithItemMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.BindingOptionWithItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.BindingOptionWithItem> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_BindingOptionWithItem", "dbo");

            // key
            builder.HasKey(t => new { t.NItemDBID, t.BOptType, t.NSlot });

            // properties
            builder.Property(t => t.NItemDBID)
                .IsRequired()
                .HasColumnName("nItemDBID")
                .HasColumnType("bigint");

            builder.Property(t => t.BOptType)
                .IsRequired()
                .HasColumnName("bOptType")
                .HasColumnType("tinyint");

            builder.Property(t => t.NSlot)
                .IsRequired()
                .HasColumnName("nSlot")
                .HasColumnType("tinyint");

            builder.Property(t => t.NOptID)
                .IsRequired()
                .HasColumnName("nOptID")
                .HasColumnType("int");

            builder.Property(t => t.NOptLvl)
                .IsRequired()
                .HasColumnName("nOptLvl")
                .HasColumnType("tinyint");

            builder.Property(t => t.NOptValue)
                .IsRequired()
                .HasColumnName("nOptValue")
                .HasColumnType("int");

            builder.Property(t => t.NParam1)
                .HasColumnName("nParam1")
                .HasColumnType("int");

            builder.Property(t => t.NParam2)
                .HasColumnName("nParam2")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_BindingOptionWithItem";
        }

        public struct Columns
        {
            public const string NItemDBID = "nItemDBID";
            public const string BOptType = "bOptType";
            public const string NSlot = "nSlot";
            public const string NOptID = "nOptID";
            public const string NOptLvl = "nOptLvl";
            public const string NOptValue = "nOptValue";
            public const string NParam1 = "nParam1";
            public const string NParam2 = "nParam2";
        }
        #endregion
    }
}
