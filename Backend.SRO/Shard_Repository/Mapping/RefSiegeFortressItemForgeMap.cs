using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSiegeFortressItemForgeMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSiegeFortressItemForge>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSiegeFortressItemForge> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSiegeFortressItemForge", "dbo");

            // key
            builder.HasKey(t => new { t.FortressID, t.RefItemID });

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int");

            builder.Property(t => t.RefItemID)
                .IsRequired()
                .HasColumnName("RefItemID")
                .HasColumnType("int");

            builder.Property(t => t.ReqGold)
                .IsRequired()
                .HasColumnName("ReqGold")
                .HasColumnType("int");

            builder.Property(t => t.ReqGP)
                .IsRequired()
                .HasColumnName("ReqGP")
                .HasColumnType("int");

            builder.Property(t => t.ForgeTimeMin)
                .IsRequired()
                .HasColumnName("ForgeTimeMin")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSiegeFortressItemForge";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string FortressID = "FortressID";
            public const string RefItemID = "RefItemID";
            public const string ReqGold = "ReqGold";
            public const string ReqGP = "ReqGP";
            public const string ForgeTimeMin = "ForgeTimeMin";
        }
        #endregion
    }
}
