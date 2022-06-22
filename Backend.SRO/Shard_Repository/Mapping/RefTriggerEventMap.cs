using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefTriggerEventMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefTriggerEvent>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefTriggerEvent> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefTriggerEvent", "dbo");

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

            // relationships
            builder.HasOne(t => t.RefTriggerCommon)
                .WithMany(t => t.RefTriggerEvents)
                .HasForeignKey(d => d.RefTriggerCommonID)
                .HasConstraintName("FK__RefTriggerEvent__RefTriggerCommon");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefTriggerEvent";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string Id = "ID";
            public const string RefTriggerCommonID = "RefTriggerCommonID";
        }
        #endregion
    }
}
