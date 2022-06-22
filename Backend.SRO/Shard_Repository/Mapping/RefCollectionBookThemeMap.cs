using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefCollectionBookThemeMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefCollectionBookTheme>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefCollectionBookTheme> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefCollectionBook_Theme", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int");

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

            builder.Property(t => t.Name128)
                .IsRequired()
                .HasColumnName("Name128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Desc128)
                .IsRequired()
                .HasColumnName("Desc128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.CompleteNum)
                .IsRequired()
                .HasColumnName("CompleteNum")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefCollectionBook_Theme";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string CodeName128 = "CodeName128";
            public const string ObjName128 = "ObjName128";
            public const string Name128 = "Name128";
            public const string Desc128 = "Desc128";
            public const string CompleteNum = "CompleteNum";
        }
        #endregion
    }
}
