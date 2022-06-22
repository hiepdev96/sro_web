using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefCollectionBookItemMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefCollectionBookItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefCollectionBookItem> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefCollectionBook_Item", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ObjName128)
                .IsRequired()
                .HasColumnName("ObjName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ThemeCodeName128)
                .IsRequired()
                .HasColumnName("ThemeCodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.SlotIndex)
                .IsRequired()
                .HasColumnName("SlotIndex")
                .HasColumnType("int");

            builder.Property(t => t.Story128)
                .IsRequired()
                .HasColumnName("Story128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.DDJFile128)
                .IsRequired()
                .HasColumnName("DDJFile128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefCollectionBook_Item";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string CodeName128 = "CodeName128";
            public const string ObjName128 = "ObjName128";
            public const string ThemeCodeName128 = "ThemeCodeName128";
            public const string SlotIndex = "SlotIndex";
            public const string Story128 = "Story128";
            public const string DDJFile128 = "DDJFile128";
        }
        #endregion
    }
}
