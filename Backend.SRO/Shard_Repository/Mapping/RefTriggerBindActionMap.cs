using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefTriggerBindActionMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefTriggerBindAction>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefTriggerBindAction> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefTriggerBindAction", "dbo");

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

            builder.Property(t => t.TriggerActionID)
                .IsRequired()
                .HasColumnName("TriggerActionID")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.TriggerRefTrigger)
                .WithMany(t => t.TriggerRefTriggerBindActions)
                .HasForeignKey(d => d.TriggerID)
                .HasConstraintName("FK__RefTriggerBindAction__RefTrigger");

            builder.HasOne(t => t.TriggerActionRefTriggerAction)
                .WithMany(t => t.TriggerActionRefTriggerBindActions)
                .HasForeignKey(d => d.TriggerActionID)
                .HasConstraintName("FK__RefTriggerBindAction__RefTriggerAction");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefTriggerBindAction";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string TriggerID = "TriggerID";
            public const string TriggerActionID = "TriggerActionID";
        }
        #endregion
    }
}
