using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefFmnCategoryTreeMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefFmnCategoryTree>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefFmnCategoryTree> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefFmnCategoryTree", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.CategoryName)
                .IsRequired()
                .HasColumnName("CategoryName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.StringID)
                .IsRequired()
                .HasColumnName("StringID")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.ParentCategoryName)
                .IsRequired()
                .HasColumnName("ParentCategoryName")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.TidGroupID)
                .IsRequired()
                .HasColumnName("TidGroupID")
                .HasColumnType("int");

            builder.Property(t => t.Degree)
                .IsRequired()
                .HasColumnName("Degree")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefFmnCategoryTree";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string CategoryName = "CategoryName";
            public const string StringID = "StringID";
            public const string ParentCategoryName = "ParentCategoryName";
            public const string TidGroupID = "TidGroupID";
            public const string Degree = "Degree";
        }
        #endregion
    }
}
