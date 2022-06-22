using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefTriggerBindEventMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefTriggerBindEvent>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefTriggerBindEvent> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefTriggerBindEvent", "dbo");

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

            builder.Property(t => t.TriggerEventID)
                .IsRequired()
                .HasColumnName("TriggerEventID")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.TriggerRefTrigger)
                .WithMany(t => t.TriggerRefTriggerBindEvents)
                .HasForeignKey(d => d.TriggerID)
                .HasConstraintName("FK__RefTriggerBindEvent__RefTrigger");

            builder.HasOne(t => t.TriggerEventRefTriggerEvent)
                .WithMany(t => t.TriggerEventRefTriggerBindEvents)
                .HasForeignKey(d => d.TriggerEventID)
                .HasConstraintName("FK__RefTriggerBindEvent__RefTriggerEvent");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefTriggerBindEvent";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string TriggerID = "TriggerID";
            public const string TriggerEventID = "TriggerEventID";
        }
        #endregion
    }
}
