using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefTriggerActionMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefTriggerAction>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefTriggerAction> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefTriggerAction", "dbo");

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

            builder.Property(t => t.Delay)
                .IsRequired()
                .HasColumnName("Delay")
                .HasColumnType("int");

            builder.Property(t => t.ParamGroupCodeName128)
                .IsRequired()
                .HasColumnName("ParamGroupCodeName128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            builder.HasOne(t => t.RefTriggerCommon)
                .WithMany(t => t.RefTriggerActions)
                .HasForeignKey(d => d.RefTriggerCommonID)
                .HasConstraintName("FK__RefTriggerAction__RefTriggerCommon");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefTriggerAction";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string RefTriggerCommonID = "RefTriggerCommonID";
            public const string Delay = "Delay";
            public const string ParamGroupCodeName128 = "ParamGroupCodeName128";
        }
        #endregion
    }
}
