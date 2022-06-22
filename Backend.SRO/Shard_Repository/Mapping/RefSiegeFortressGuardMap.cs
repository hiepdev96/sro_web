using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class RefSiegeFortressGuardMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.RefSiegeFortressGuard>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.RefSiegeFortressGuard> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_RefSiegeFortressGuard", "dbo");

            // key
            builder.HasKey(t => new { t.FortressID, t.GuardRefObjID });

            // properties
            builder.Property(t => t.Service)
                .IsRequired()
                .HasColumnName("Service")
                .HasColumnType("tinyint");

            builder.Property(t => t.FortressID)
                .IsRequired()
                .HasColumnName("FortressID")
                .HasColumnType("int");

            builder.Property(t => t.GuardRefObjID)
                .IsRequired()
                .HasColumnName("GuardRefObjID")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_RefSiegeFortressGuard";
        }

        public struct Columns
        {
            public const string Service = "Service";
            public const string FortressID = "FortressID";
            public const string GuardRefObjID = "GuardRefObjID";
        }
        #endregion
    }
}
