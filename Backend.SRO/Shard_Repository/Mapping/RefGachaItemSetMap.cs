using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefGachaItemSetMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefGachaItemSet>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefGachaItemSet> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefGachaItemSet", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.SetID)
                .IsRequired()
                .HasColumnName("Set_ID")
                .HasColumnType("int");

            builder.Property(t => t.RefItemID)
                .IsRequired()
                .HasColumnName("RefItemID")
                .HasColumnType("int");

            builder.Property(t => t.Ratio)
                .IsRequired()
                .HasColumnName("Ratio")
                .HasColumnType("smallint");

            builder.Property(t => t.Count)
                .IsRequired()
                .HasColumnName("Count")
                .HasColumnType("smallint")
                .HasDefaultValueSql("(1)");

            builder.Property(t => t.GachaID)
                .IsRequired()
                .HasColumnName("GachaID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Visible)
                .IsRequired()
                .HasColumnName("Visible")
                .HasColumnType("tinyint");

            builder.Property(t => t.Param1)
                .IsRequired()
                .HasColumnName("param1")
                .HasColumnType("int");

            builder.Property(t => t.Param1Desc128)
                .IsRequired()
                .HasColumnName("param1_Desc128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129)
                .HasDefaultValueSql("('xxx')");

            builder.Property(t => t.Param2)
                .IsRequired()
                .HasColumnName("param2")
                .HasColumnType("int");

            builder.Property(t => t.Param2Desc128)
                .IsRequired()
                .HasColumnName("param2_Desc128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129)
                .HasDefaultValueSql("('xxx')");

            builder.Property(t => t.Param3)
                .IsRequired()
                .HasColumnName("param3")
                .HasColumnType("int");

            builder.Property(t => t.Param3Desc128)
                .IsRequired()
                .HasColumnName("param3_Desc128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129)
                .HasDefaultValueSql("('xxx')");

            builder.Property(t => t.Param4)
                .IsRequired()
                .HasColumnName("param4")
                .HasColumnType("int");

            builder.Property(t => t.Param4Desc128)
                .IsRequired()
                .HasColumnName("param4_Desc128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129)
                .HasDefaultValueSql("('xxx')");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefGachaItemSet";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string SetID = "Set_ID";
            public const string RefItemID = "RefItemID";
            public const string Ratio = "Ratio";
            public const string Count = "Count";
            public const string GachaID = "GachaID";
            public const string Visible = "Visible";
            public const string Param1 = "param1";
            public const string Param1Desc128 = "param1_Desc128";
            public const string Param2 = "param2";
            public const string Param2Desc128 = "param2_Desc128";
            public const string Param3 = "param3";
            public const string Param3Desc128 = "param3_Desc128";
            public const string Param4 = "param4";
            public const string Param4Desc128 = "param4_Desc128";
        }
        #endregion
    }
}
