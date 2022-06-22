using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefDropItemGroupMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefDropItemGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefDropItemGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefDropItemGroup", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.RefItemGroupID)
                .IsRequired()
                .HasColumnName("RefItemGroupID")
                .HasColumnType("int");

            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.RefItemID)
                .IsRequired()
                .HasColumnName("RefItemID")
                .HasColumnType("int");

            builder.Property(t => t.SelectRatio)
                .IsRequired()
                .HasColumnName("SelectRatio")
                .HasColumnType("real");

            builder.Property(t => t.RefMagicGroupID)
                .IsRequired()
                .HasColumnName("RefMagicGroupID")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.RefItemRefObjCommon)
                .WithMany(t => t.RefItemRefDropItemGroups)
                .HasForeignKey(d => d.RefItemID)
                .HasConstraintName("FK__RefDropItemGroup__RefObjCommon");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefDropItemGroup";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string RefItemGroupID = "RefItemGroupID";
            public const string CodeName128 = "CodeName128";
            public const string RefItemID = "RefItemID";
            public const string SelectRatio = "SelectRatio";
            public const string RefMagicGroupID = "RefMagicGroupID";
        }
        #endregion
    }
}
