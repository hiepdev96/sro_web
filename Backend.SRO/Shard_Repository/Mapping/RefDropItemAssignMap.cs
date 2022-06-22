using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefDropItemAssignMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefDropItemAssign>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefDropItemAssign> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefDropItemAssign", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("int");

            builder.Property(t => t.RefItemID)
                .IsRequired()
                .HasColumnName("RefItemID")
                .HasColumnType("int");

            builder.Property(t => t.ProbRelative)
                .IsRequired()
                .HasColumnName("Prob_Relative")
                .HasColumnType("int");

            builder.Property(t => t.ProbAbsolute)
                .IsRequired()
                .HasColumnName("Prob_Absolute")
                .HasColumnType("int");

            builder.Property(t => t.AssignedGroup)
                .IsRequired()
                .HasColumnName("AssignedGroup")
                .HasColumnType("int");

            builder.Property(t => t.DropCount)
                .IsRequired()
                .HasColumnName("DropCount")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefDropItemAssign";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string RefItemID = "RefItemID";
            public const string ProbRelative = "Prob_Relative";
            public const string ProbAbsolute = "Prob_Absolute";
            public const string AssignedGroup = "AssignedGroup";
            public const string DropCount = "DropCount";
        }
        #endregion
    }
}
