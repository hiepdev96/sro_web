using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefTriggerConditionMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefTriggerCondition>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefTriggerCondition> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefTriggerCondition", "dbo");

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

            builder.Property(t => t.RefTriggerCommonID)
                .IsRequired()
                .HasColumnName("RefTriggerCommonID")
                .HasColumnType("int");

            builder.Property(t => t.OnTrue)
                .IsRequired()
                .HasColumnName("OnTrue")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.OnFalse)
                .IsRequired()
                .HasColumnName("OnFalse")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Sequence)
                .IsRequired()
                .HasColumnName("Sequence")
                .HasColumnType("smallint");

            builder.Property(t => t.ParamGroupCodeName128)
                .IsRequired()
                .HasColumnName("ParamGroupCodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            builder.HasOne(t => t.RefTriggerCommon)
                .WithMany(t => t.RefTriggerConditions)
                .HasForeignKey(d => d.RefTriggerCommonID)
                .HasConstraintName("FK__RefTriggerCondition__RefTriggerCommon");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefTriggerCondition";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string RefTriggerCommonID = "RefTriggerCommonID";
            public const string OnTrue = "OnTrue";
            public const string OnFalse = "OnFalse";
            public const string Sequence = "Sequence";
            public const string ParamGroupCodeName128 = "ParamGroupCodeName128";
        }
        #endregion
    }
}
