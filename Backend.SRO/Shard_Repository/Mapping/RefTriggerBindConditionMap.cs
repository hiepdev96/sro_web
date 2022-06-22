using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefTriggerBindConditionMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefTriggerBindCondition>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefTriggerBindCondition> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefTriggerBindCondition", "dbo");

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

            builder.Property(t => t.TriggerID)
                .IsRequired()
                .HasColumnName("TriggerID")
                .HasColumnType("int");

            builder.Property(t => t.TriggerConditionID)
                .IsRequired()
                .HasColumnName("TriggerConditionID")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.TriggerRefTrigger)
                .WithMany(t => t.TriggerRefTriggerBindConditions)
                .HasForeignKey(d => d.TriggerID)
                .HasConstraintName("FK__RefTriggerBindCondition__RefTrigger");

            builder.HasOne(t => t.TriggerConditionRefTriggerCondition)
                .WithMany(t => t.TriggerConditionRefTriggerBindConditions)
                .HasForeignKey(d => d.TriggerConditionID)
                .HasConstraintName("FK__RefTriggerBindCondition__RefTriggerCondition");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefTriggerBindCondition";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string TriggerID = "TriggerID";
            public const string TriggerConditionID = "TriggerConditionID";
        }
        #endregion
    }
}
