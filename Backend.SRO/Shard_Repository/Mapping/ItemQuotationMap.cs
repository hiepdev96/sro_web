using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class ItemQuotationMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.ItemQuotation>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.ItemQuotation> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_ItemQuotation", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("int");

            builder.Property(t => t.AssocNPC)
                .IsRequired()
                .HasColumnName("AssocNPC")
                .HasColumnType("int");

            builder.Property(t => t.RefItemID)
                .IsRequired()
                .HasColumnName("RefItemID")
                .HasColumnType("int");

            builder.Property(t => t.BaseQuot)
                .IsRequired()
                .HasColumnName("BaseQuot")
                .HasColumnType("real");

            builder.Property(t => t.QuotLB)
                .IsRequired()
                .HasColumnName("Quot_LB")
                .HasColumnType("real");

            builder.Property(t => t.QuotUB)
                .IsRequired()
                .HasColumnName("Quot_UB")
                .HasColumnType("real");

            builder.Property(t => t.BaseStockAmount)
                .IsRequired()
                .HasColumnName("BaseStockAmount")
                .HasColumnType("int");

            builder.Property(t => t.FluctuateAmount)
                .IsRequired()
                .HasColumnName("FluctuateAmount")
                .HasColumnType("int");

            builder.Property(t => t.CurStockAmount)
                .IsRequired()
                .HasColumnName("CurStockAmount")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_ItemQuotation";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string Service = "Service";
            public const string AssocNPC = "AssocNPC";
            public const string RefItemID = "RefItemID";
            public const string BaseQuot = "BaseQuot";
            public const string QuotLB = "Quot_LB";
            public const string QuotUB = "Quot_UB";
            public const string BaseStockAmount = "BaseStockAmount";
            public const string FluctuateAmount = "FluctuateAmount";
            public const string CurStockAmount = "CurStockAmount";
        }
        #endregion
    }
}
