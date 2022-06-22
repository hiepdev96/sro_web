using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefGameWorldGroupMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefGameWorldGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefGameWorldGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefGameWorldGroup", "dbo");

            // key
            builder.HasNoKey();

            // properties
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

            builder.Property(t => t.ObjName128)
                .IsRequired()
                .HasColumnName("ObjName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.ConfigGroupCodeName128)
                .IsRequired()
                .HasColumnName("ConfigGroupCodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefGameWorldGroup";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string CodeName128 = "CodeName128";
            public const string ObjName128 = "ObjName128";
            public const string ConfigGroupCodeName128 = "ConfigGroupCodeName128";
        }
        #endregion
    }
}
