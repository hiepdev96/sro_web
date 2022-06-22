using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefShardContentConfigMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefShardContentConfig>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefShardContentConfig> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefShardContentConfig", "dbo");

            // key
            builder.HasNoKey();

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

            builder.Property(t => t.CodeDesc128)
                .IsRequired()
                .HasColumnName("CodeDesc128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Value)
                .IsRequired()
                .HasColumnName("Value")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Type)
                .HasColumnName("Type")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefShardContentConfig";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string CodeName128 = "CodeName128";
            public const string CodeDesc128 = "CodeDesc128";
            public const string Value = "Value";
            public const string Type = "Type";
        }
        #endregion
    }
}
