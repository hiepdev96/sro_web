using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefTriggerVariableMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefTriggerVariable>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefTriggerVariable> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefTriggerVariable", "dbo");

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

            builder.Property(t => t.BindTriggerID)
                .IsRequired()
                .HasColumnName("BindTriggerID")
                .HasColumnType("int");

            builder.Property(t => t.CodeName128)
                .IsRequired()
                .HasColumnName("CodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("varchar(33)")
                .HasMaxLength(33);

            builder.Property(t => t.Value)
                .IsRequired()
                .HasColumnName("Value")
                .HasColumnType("int");

            builder.Property(t => t.Comment128)
                .HasColumnName("Comment128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            builder.HasOne(t => t.BindTriggerRefTrigger)
                .WithMany(t => t.BindTriggerRefTriggerVariables)
                .HasForeignKey(d => d.BindTriggerID)
                .HasConstraintName("FK__RefTriggerVariable__RefTrigger");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefTriggerVariable";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string BindTriggerID = "BindTriggerID";
            public const string CodeName128 = "CodeName128";
            public const string Type = "Type";
            public const string Value = "Value";
            public const string Comment128 = "Comment128";
        }
        #endregion
    }
}
