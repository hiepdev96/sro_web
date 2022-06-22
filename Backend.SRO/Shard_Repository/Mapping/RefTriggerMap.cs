using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefTriggerMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefTrigger>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefTrigger> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefTrigger", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("int");

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.IsActive)
                .IsRequired()
                .HasColumnName("IsActive")
                .HasColumnType("tinyint");

            builder.Property(t => t.IsRepeat)
                .IsRequired()
                .HasColumnName("IsRepeat")
                .HasColumnType("tinyint");

            builder.Property(t => t.Comment512)
                .HasColumnName("Comment512")
                .HasColumnType("varchar(513)")
                .HasMaxLength(513);

            builder.Property(t => t.IndexNumber)
                .IsRequired()
                .HasColumnName("IndexNumber")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefTrigger";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string CodeName128 = "CodeName128";
            public const string IsActive = "IsActive";
            public const string IsRepeat = "IsRepeat";
            public const string Comment512 = "Comment512";
            public const string IndexNumber = "IndexNumber";
        }
        #endregion
    }
}
