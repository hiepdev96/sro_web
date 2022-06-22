using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class BlockedWhisperersMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.BlockedWhisperers>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.BlockedWhisperers> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_BlockedWhisperers", "dbo");

            // key
            builder.HasKey(t => t.OwnerID);

            // properties
            builder.Property(t => t.OwnerID)
                .IsRequired()
                .HasColumnName("OwnerID")
                .HasColumnType("int");

            builder.Property(t => t.TargetName)
                .IsRequired()
                .HasColumnName("TargetName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            // relationships
            builder.HasOne(t => t.OwnerChar)
                .WithOne(t => t.OwnerBlockedWhisperers)
                .HasForeignKey<VsroShard.Shard_Repository.Entities.BlockedWhisperers>(d => d.OwnerID)
                .HasConstraintName("FK___BlockedW__Owner__0D4FE554");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_BlockedWhisperers";
        }

        public struct Columns
        {
            public const string OwnerID = "OwnerID";
            public const string TargetName = "TargetName";
        }
        #endregion
    }
}
