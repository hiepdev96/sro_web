using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefTriggerCategoryBindTriggerMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefTriggerCategoryBindTrigger>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefTriggerCategoryBindTrigger> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefTriggerCategoryBindTrigger", "dbo");

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

            builder.Property(t => t.TriggerCategoryID)
                .IsRequired()
                .HasColumnName("TriggerCategoryID")
                .HasColumnType("int");

            builder.Property(t => t.TriggerID)
                .IsRequired()
                .HasColumnName("TriggerID")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.TriggerRefTrigger)
                .WithMany(t => t.TriggerRefTriggerCategoryBindTriggers)
                .HasForeignKey(d => d.TriggerID)
                .HasConstraintName("FK__RefTriggerCategoryBindTrigger__RefTrigger");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefTriggerCategoryBindTrigger";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string TriggerCategoryID = "TriggerCategoryID";
            public const string TriggerID = "TriggerID";
        }
        #endregion
    }
}
